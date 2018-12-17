namespace Catch_A_Fire
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOt4et = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickPO = new System.Windows.Forms.DateTimePicker();
            this.dtPickC = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.dvGPlatej = new System.Windows.Forms.DataGridView();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSlide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGPlatej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(163)))));
            this.pnlTop.Controls.Add(this.btnMin);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.pnlTitle);
            this.pnlTop.Controls.Add(this.lblCurrentUser);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1155, 40);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.pnlTitle.Controls.Add(this.pctMenu);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(229, 40);
            this.pnlTitle.TabIndex = 1;
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Финансовый отчёт";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(617, 10);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(464, 20);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Вы авторизованы как ";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCurrentUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.pnlSlide.Controls.Add(this.btnCategory);
            this.pnlSlide.Controls.Add(this.btnUser);
            this.pnlSlide.Controls.Add(this.btnAddUser);
            this.pnlSlide.Controls.Add(this.btnMain);
            this.pnlSlide.Controls.Add(this.lblAddUser);
            this.pnlSlide.Controls.Add(this.label4);
            this.pnlSlide.Controls.Add(this.label3);
            this.pnlSlide.Controls.Add(this.label2);
            this.pnlSlide.Location = new System.Drawing.Point(32, 40);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(285, 218);
            this.pnlSlide.TabIndex = 1;
            // 
            // lblAddUser
            // 
            this.lblAddUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddUser.Location = new System.Drawing.Point(87, 160);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(108, 43);
            this.lblAddUser.TabIndex = 0;
            this.lblAddUser.Text = "Добавить пользователя";
            this.lblAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(97, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Создать категорию";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(202, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выход";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Главная";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btnOt4et);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.dtPickPO);
            this.panel1.Controls.Add(this.dtPickC);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblPO);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnOt4et
            // 
            this.btnOt4et.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOt4et.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.btnOt4et.FlatAppearance.BorderSize = 0;
            this.btnOt4et.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnOt4et.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnOt4et.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOt4et.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOt4et.ForeColor = System.Drawing.Color.White;
            this.btnOt4et.Location = new System.Drawing.Point(1020, 8);
            this.btnOt4et.Name = "btnOt4et";
            this.btnOt4et.Size = new System.Drawing.Size(109, 29);
            this.btnOt4et.TabIndex = 16;
            this.btnOt4et.Text = "Отчёт";
            this.btnOt4et.UseVisualStyleBackColor = false;
            this.btnOt4et.Click += new System.EventHandler(this.btnOt4et_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(900, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 29);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(142)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(780, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(109, 29);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(575, 13);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(158, 21);
            this.cmbCategory.TabIndex = 15;
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // dtPickPO
            // 
            this.dtPickPO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickPO.Location = new System.Drawing.Point(323, 13);
            this.dtPickPO.Name = "dtPickPO";
            this.dtPickPO.Size = new System.Drawing.Size(131, 20);
            this.dtPickPO.TabIndex = 14;
            this.dtPickPO.ValueChanged += new System.EventHandler(this.dtPickPO_ValueChanged);
            // 
            // dtPickC
            // 
            this.dtPickC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickC.Location = new System.Drawing.Point(149, 13);
            this.dtPickC.Name = "dtPickC";
            this.dtPickC.Size = new System.Drawing.Size(131, 20);
            this.dtPickC.TabIndex = 14;
            this.dtPickC.ValueChanged += new System.EventHandler(this.dtPickC_ValueChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Location = new System.Drawing.Point(485, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Категория:";
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPO.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPO.Location = new System.Drawing.Point(286, 12);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(31, 20);
            this.lblPO.TabIndex = 0;
            this.lblPO.Text = "ПО";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblC.Location = new System.Drawing.Point(125, 12);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(18, 20);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "С";
            // 
            // dvGPlatej
            // 
            this.dvGPlatej.AllowUserToAddRows = false;
            this.dvGPlatej.AllowUserToDeleteRows = false;
            this.dvGPlatej.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvGPlatej.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dvGPlatej.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGPlatej.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvGPlatej.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGPlatej.Location = new System.Drawing.Point(0, 40);
            this.dvGPlatej.Name = "dvGPlatej";
            this.dvGPlatej.ReadOnly = true;
            this.dvGPlatej.Size = new System.Drawing.Size(1155, 513);
            this.dvGPlatej.TabIndex = 3;
            // 
            // btnCategory
            // 
            this.btnCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(117, 22);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategory.Size = new System.Drawing.Size(48, 43);
            this.btnCategory.TabIndex = 13;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(218, 22);
            this.btnUser.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUser.Size = new System.Drawing.Size(48, 43);
            this.btnUser.TabIndex = 12;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(117, 114);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddUser.Size = new System.Drawing.Size(48, 43);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnMain
            // 
            this.btnMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(18, 22);
            this.btnMain.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnMain.Name = "btnMain";
            this.btnMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMain.Size = new System.Drawing.Size(48, 43);
            this.btnMain.TabIndex = 12;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Catch_A_Fire.Properties.Resources.icons8_вычитание_24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(89, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(33, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(79)))), ((int)(((byte)(158)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Image = global::Catch_A_Fire.Properties.Resources.icons8_сложение_24;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(41, 0);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInsert.Size = new System.Drawing.Size(33, 45);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMin.Location = new System.Drawing.Point(1087, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(34, 40);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1121, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctMenu
            // 
            this.pctMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMenu.Image = global::Catch_A_Fire.Properties.Resources.icons8_меню_26;
            this.pctMenu.Location = new System.Drawing.Point(9, 9);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(28, 23);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMenu.TabIndex = 1;
            this.pctMenu.TabStop = false;
            this.pctMenu.Click += new System.EventHandler(this.pctMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1155, 598);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.dvGPlatej);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Финансы";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSlide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGPlatej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtPickPO;
        private System.Windows.Forms.DateTimePicker dtPickC;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnOt4et;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.DataGridView dvGPlatej;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblAddUser;
    }
}

