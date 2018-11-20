﻿using System;
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

       
        public MainForm()
        {
            InitializeComponent(); //Инициализация
            CenterToScreen(); //Появление в центре экрана
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();//Выход
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
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Инициализация формы добавления платежа
            AddForm addform = new AddForm();
            addform.ShowDialog();
        }
    }
}
