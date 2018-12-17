using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Catch_A_Fire
{
    public partial class ShowCategory_Form : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ShowCategory_Form()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //Закрыть
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

        //Загрузка
        private void LoadData()
        {
            using (Platej_Entity platez = new Platej_Entity())
            {
                platez.Configuration.ProxyCreationEnabled = false;
                dvGPlatej.DataSource = platez.Category_Select(null).ToList();
            }
        }

        //Загрузка формы
        private void ShowCategory_Form_Load(object sender, EventArgs e)
        {
            LoadData(); //Загрузка
        }

        //Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Проверка, чтобы что-то было написано в поле
            if (txtNameCategory.Text.Length > 0)
            {
                try
                {
                    using (Platej_Entity platez = new Platej_Entity())
                    {
                        platez.Configuration.ProxyCreationEnabled = false;
                        //Вносим данные в бд с помощью процедуры
                        platez.Category_Insert(txtNameCategory.Text);
                        MessageBox.Show("Категория " + txtNameCategory.Text + " была успешно добавлена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.  Причина: " + ex.Message);
                }
                finally
                {
                    txtID.Clear();
                    txtNameCategory.Clear();
                    LoadData();
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        //Передача данных в textbox
        private void dvGPlatej_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dvGPlatej.CurrentRow.Cells["ID"].Value.ToString();
            txtNameCategory.Text = dvGPlatej.CurrentRow.Cells["Наименование"].Value.ToString();
        }

        //Удаление
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                try
                {
                    using (Platej_Entity platez = new Platej_Entity())
                    {
                        platez.Configuration.ProxyCreationEnabled = false;
                        //Вносим данные в бд с помощью процедуры
                        int id_category = int.Parse(txtID.Text);
                        platez.Category_Delete(id_category);
                        MessageBox.Show("Категория " + txtNameCategory.Text + " была успешно добавлена");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.  Причина: " + ex.Message);
                }
                finally
                {
                    txtID.Clear();
                    txtNameCategory.Clear();
                    LoadData();
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNameCategory.Clear();
            LoadData();
        }
    }
}
