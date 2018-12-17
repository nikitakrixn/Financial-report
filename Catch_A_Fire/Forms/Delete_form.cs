using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_A_Fire
{
    public partial class Delete_form : Form
    {

        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int getID { get; set; }

        public Delete_form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();//Выход
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Отмена
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    //Создаём платёж и сравниваем его с полученными данными
                    Paymont paymount = platez.Paymont
                        .Where(p => p.id_platez == getID)
                        .FirstOrDefault();//Ссылка на объект платежи

                    //Удаляем платёж
                    platez.Paymont.Remove(paymount);
                    platez.SaveChanges();
                    MessageBox.Show("Запись " + lblDeleteSecond.Text + " была успешно удалена.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось удалить данные.  Причина: " + ex.Message);
            }
        }
    }
}
