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
    public partial class AddForm : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close() ;//Выход
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

        //Загрузка с бд
        private void LoadData()
        {
            using (Platej_Entity platez = new Platej_Entity())
            {
                platez.Configuration.ProxyCreationEnabled = false;
                cmbCategory.DataSource = platez.Category.ToList();
                cmbCategory.ValueMember = "id_category";
                cmbCategory.DisplayMember = "Name";
            }
        }

        //Загрузка
        private void AddForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbCategory.SelectedValue = -1;
        }

        //Добавление
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id_category = Convert.ToInt32(cmbCategory.SelectedValue);
            int id_user = Convert.ToInt32(txtUser.Text);
            if(txtNamePlatej.Text.Length > 0 && txtPrice.Text.Length > 0 && cmbCategory.Text.Length > 0)
            {
                try
                {
                    using (Platej_Entity platez = new Platej_Entity())
                    {
                        //Извелечение пользователя к которому добавляется заказ
                        Users user = platez.Users
                            .Where(u => u.id_user == id_user)
                            .FirstOrDefault(); //Ссылка на объект пользователя

                        //Извлечения категории для пользователя
                        Category category = platez.Category
                            .Where(c => c.id_category == id_category)
                            .FirstOrDefault();//Ссылка на объект категории

                        //Создаём платёж
                        Paymont paymount = new Paymont()
                        {
                            Name = txtNamePlatej.Text.Trim(),
                            Quantity = Convert.ToInt32(updownKolvo.Value),
                            Price = Convert.ToDouble(txtPrice.Text),
                            Date = DateTime.Now,
                            Users = user,
                            Category = category
                        }; //Ссылка на объект платежи

                        platez.Paymont.Add(paymount);
                        platez.SaveChanges();
                        MessageBox.Show("Платёж " + txtNamePlatej.Text.Trim() + " был успешно добавлен");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.  Причина: " + ex.Message);
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");

        }

        //Отмена
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
