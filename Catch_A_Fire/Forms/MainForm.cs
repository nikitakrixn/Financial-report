using Catch_A_Fire.Forms;
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
    public partial class MainForm : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Paymont paymount = new Paymont(); //Ссылка на объект платежи
        Category category = new Category(); //Ссылка на объект категории
        LoginForm loginform = new LoginForm(); //Ссылка на форму логин

        public MainForm()
        {
            InitializeComponent(); //Инициализация
            CenterToScreen(); //Появление в центре экрана
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);//Выход
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

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            //Перемещение
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //Инициализация формы пользователя
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Уведомление",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Инициализация формы добавления платежа
            try
            {
                using(AddForm addform = new AddForm())
                {
                    addform.txtUser.Text = Convert.ToString(loginform.userid_select);
                    addform.ShowDialog();
                }
            }
            catch { throw; }
            finally { pnlSlide.Visible = false; LoadData();  }
            
        }

        private void FullLoad()
        {
            pnlSlide.Visible = false;
            LoadData(); //Загрузка данных
            LoadCurrentUser(); //Загрузка текущего пользователя
            if (loginform.itsAdmin == 0)
            {
                btnAddUser.Visible = false;
                lblAddUser.Visible = false;
            }
            cmbCategory.SelectedValue = -1;
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
                dvGPlatej.DataSource = platez.Paymount_Select(loginform.userid_select).ToList();
                dvGPlatej.Columns["ID"].Visible = false;
            }
        }

        //Загрузка текущего пользователя
        private void LoadCurrentUser()
        {
            
            using (Platej_Entity platez = new Platej_Entity())
            {
                if (loginform.userid_select > 0)
                {
                    //Загружаем ФИО из текущего пользователя
                    var userCurrent =
                        (from U in platez.Users
                         where U.id_user == loginform.userid_select //Сравнение данных с бд
                         select new
                         { U.FIO })
                         .FirstOrDefault();
                    lblCurrentUser.Text = "";
                    lblCurrentUser.Text = "Вы авторизованы как " + userCurrent.FIO;
                }
                else lblCurrentUser.Text = "Вы авторизованы под " + loginform.cmbLogin.Text;
            }
        }

        //Загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            loginform.ShowDialog();
            this.Show();
            FullLoad();
        }

        //Очистить значения
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtPickC.Text = null;
            dtPickPO.Text = null;
            cmbCategory.Text = null;
            cmbCategory.SelectedValue = -1;
            LoadData();
        }

        //Поиск по категории
        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    dvGPlatej.DataSource = platez.Paymount_Search(loginform.userid_select, Convert.ToInt32(cmbCategory.SelectedValue));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Поиск по категории и дате
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    dvGPlatej.DataSource = platez.Paymount_Full_Search(loginform.userid_select, Convert.ToInt32(cmbCategory.SelectedValue), dtPickC.Value, dtPickPO.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Поиск по дате
        private void dtPickC_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    dvGPlatej.DataSource = platez.Paymount_Period(loginform.userid_select, dtPickC.Value, dtPickPO.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Поиск по дате
        private void dtPickPO_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    dvGPlatej.DataSource = platez.Paymount_Period(loginform.userid_select, dtPickC.Value, dtPickPO.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Загрузка
        private void btnMain_Click(object sender, EventArgs e)
        {
            pnlSlide.Visible = false;
            LoadData();
        }

        //Удаление записи
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using(Delete_form delete = new Delete_form())
            {
                try
                {
                    delete.getID = (int)dvGPlatej.CurrentRow.Cells["ID"].Value;
                    delete.lblDeleteSecond.Text = string.Format("{0} за {1}", dvGPlatej.CurrentRow.Cells["Наименование_платежа"].Value.ToString(), dvGPlatej.CurrentRow.Cells["Дата_платежа"].FormattedValue.ToString());
                    delete.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pnlSlide.Visible = false;
                    LoadData();
                }
            }
        }

        //Добавление категории
        private void btnCategory_Click(object sender, EventArgs e)
        {
            //Инициализация формы добавления категории
            try
            {
                using (ShowCategory_Form addform = new ShowCategory_Form())
                {
                    this.Hide();
                    addform.ShowDialog();
                    this.Show();
                }
            }
            catch { throw; }
            finally { pnlSlide.Visible = false; LoadData(); }
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {
            if (pnlSlide.Visible == false)
                pnlSlide.Visible = true;
            else pnlSlide.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (AddUser adduser = new AddUser())
            {
                try
                {
                    adduser.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    pnlSlide.Visible = false;
                    LoadData();
                }
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FullLoad();
        }

        private void btnOt4et_Click(object sender, EventArgs e)
        {
            List<Paymount_Select_Result> paylist = dvGPlatej.DataSource as List<Paymount_Select_Result>;
            if(paylist != null)
            {
                using(ReportView Freport = new ReportView(paylist))
                {
                    Freport.ShowDialog();
                }
            }
        }
    }
}
