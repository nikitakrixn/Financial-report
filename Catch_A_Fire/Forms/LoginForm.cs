using System;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Catch_A_Fire
{
    public partial class LoginForm : Form
    {
        //Перетаскивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Переменная для того, чтобы узнавать под каком пользователем ты авторизовался
        public int userid_select = 0;

        //Переменная для того, чтобы узнавать админ ли это
        public int itsAdmin = 0;

        public LoginForm()
        {
            InitializeComponent();
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

        //Загрузка из бд
        private void LoadData()
        {
            using (Platej_Entity platez = new Platej_Entity())
            {
                //Осуществляет выборку данных всех SQL Loginov
                //Затем задаёт ему тип стринг и заполняет комбобкс
                cmbLogin.DataSource = platez.Database
                    .SqlQuery<string>("SELECT name from sys.sql_logins Where name NOT IN ('##MS_PolicyEventProcessingLogin##', '##MS_PolicyTsqlExecutionLogin##')")
                    .ToList(); 
            }
        }

        //Загрузка формы
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            LoadData();
            cmbLogin.SelectedIndex = -1;
        }

        //Показать пароль
        private void chkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPass.Checked == true) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }

        //Авторизоваться
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (Platej_Entity platez = new Platej_Entity())
                {
                    //Загрузка пользователя
                    //Сравнение есть ли пользователь в таблице
                    var User = platez.Users.FirstOrDefault(u => u.Login == cmbLogin.Text);
                    //Пытаемся подключится к бд
                    if (!TestConnection())
                    {
                        MessageBox.Show("Не верный пароль.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if(User != null)
                        {
                            userid_select = User.id_user;
                            MessageBox.Show("Вы авторизовались под " + cmbLogin.Text, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            userid_select = 0;
                            MessageBox.Show("Вы авторизовались под " + cmbLogin.Text, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к серверу.  Причина: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Проверка подключения
        private bool TestConnection()
        {
            //Передача параметров из конфигурации в строку
            string connectionString = ConfigurationManager.ConnectionStrings["Acc_test"].ConnectionString;

            //Мой домашний сервер
            var homeserver = string.Format(@"{0}\SQLEXPRESS", Environment.MachineName);

            //Сервер в колледже
            var server = Environment.MachineName;

            //Заносим данные в строку подключения
            connectionString = string.Format(connectionString, server, cmbLogin.Text, txtPassword.Text);
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                try
                {
                    //Выполняем подключение
                    connection.Open();

                    //Выполняем запрос на распознавание роли db_owner
                    using (SqlCommand cmd = new SqlCommand("SELECT IS_MEMBER ('db_owner')", connection))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                for(int i = 0; i < dr.FieldCount; i++)
                                {
                                    //Вносим данные в переменную
                                    itsAdmin = Convert.ToInt32(dr.GetValue(i));
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Не удалось подключиться к серверу.  Причина: " + ex.Message);
                    return false;
                }
                finally
                {
                    //Закрываем подключение
                    connection.Close();
                }
                return true;
            }
        }
    }
}
