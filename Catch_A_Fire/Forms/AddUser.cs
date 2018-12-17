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

namespace Catch_A_Fire.Forms
{
    public partial class AddUser : Form
    {

        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 3 && txtPass.Text.Length > 3 && txtFIO.Text.Length > 6 && txtPonCode.Text.Length >= 3)
            {
                try
                {
                    using (Platej_Entity platez = new Platej_Entity())
                    {
                        int pincode = Convert.ToInt32(txtPonCode.Text);
                        platez.Users_Insert(txtLogin.Text, txtPass.Text, txtFIO.Text, pincode);
                        MessageBox.Show("Пользователь " + txtLogin.Text + " был успешно добавлен");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.  Причина: " + ex.Message);
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
