using System.Windows.Forms;

namespace GUI
{
    partial class FrMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnTaoQR = new FontAwesome.Sharp.IconButton();
            this.btnDangxuat = new FontAwesome.Sharp.IconButton();
            this.btnTaikhoan = new FontAwesome.Sharp.IconButton();
            this.btnKhachhang = new FontAwesome.Sharp.IconButton();
            this.btnSanpham = new FontAwesome.Sharp.IconButton();
            this.btnThongke = new FontAwesome.Sharp.IconButton();
            this.btnNhanvien = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDesktops = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelTitlbar = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.menuTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemThongTinNV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDesktops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitlbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.menuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.lblEmail);
            this.panelMenu.Controls.Add(this.btnTaoQR);
            this.panelMenu.Controls.Add(this.btnDangxuat);
            this.panelMenu.Controls.Add(this.btnTaikhoan);
            this.panelMenu.Controls.Add(this.btnKhachhang);
            this.panelMenu.Controls.Add(this.btnSanpham);
            this.panelMenu.Controls.Add(this.btnThongke);
            this.panelMenu.Controls.Add(this.btnNhanvien);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(287, 979);
            this.panelMenu.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.ForeColor = System.Drawing.Color.Cyan;
            this.lblEmail.Location = new System.Drawing.Point(0, 869);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Đăng nhập để sử dụng";
            // 
            // btnTaoQR
            // 
            this.btnTaoQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoQR.FlatAppearance.BorderSize = 0;
            this.btnTaoQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoQR.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaoQR.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            this.btnTaoQR.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTaoQR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaoQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoQR.Location = new System.Drawing.Point(0, 501);
            this.btnTaoQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoQR.Name = "btnTaoQR";
            this.btnTaoQR.Size = new System.Drawing.Size(287, 80);
            this.btnTaoQR.TabIndex = 8;
            this.btnTaoQR.Text = "Tạo QR";
            this.btnTaoQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoQR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoQR.UseVisualStyleBackColor = true;
            this.btnTaoQR.Click += new System.EventHandler(this.btnTaoQR_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangxuat.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnDangxuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 889);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(287, 90);
            this.btnDangxuat.TabIndex = 7;
            this.btnDangxuat.Text = "Đăng nhập";
            this.btnDangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaikhoan.FlatAppearance.BorderSize = 0;
            this.btnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaikhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaikhoan.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnTaikhoan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTaikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.Location = new System.Drawing.Point(0, 421);
            this.btnTaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(287, 80);
            this.btnTaikhoan.TabIndex = 6;
            this.btnTaikhoan.Text = "Tài Khoản";
            this.btnTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaikhoan.UseVisualStyleBackColor = true;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            this.btnTaikhoan.MouseHover += new System.EventHandler(this.btnTaikhoan_MouseHover);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachhang.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnKhachhang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachhang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 341);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(287, 80);
            this.btnKhachhang.TabIndex = 5;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanpham.FlatAppearance.BorderSize = 0;
            this.btnSanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanpham.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSanpham.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btnSanpham.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanpham.Location = new System.Drawing.Point(0, 261);
            this.btnSanpham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(287, 80);
            this.btnSanpham.TabIndex = 4;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btbSanpham_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThongke.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnThongke.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 181);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(287, 80);
            this.btnThongke.TabIndex = 3;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanvien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNhanvien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(0, 101);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(287, 80);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 101);
            this.panel3.TabIndex = 1;
            // 
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Image = global::GUI.Properties.Resources.images;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(287, 101);
            this.panelHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelHome.TabIndex = 0;
            this.panelHome.TabStop = false;
            this.panelHome.Click += new System.EventHandler(this.panelHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelDesktops);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelTitlbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(287, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 979);
            this.panel2.TabIndex = 1;
            // 
            // panelDesktops
            // 
            this.panelDesktops.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktops.Controls.Add(this.pictureBox1);
            this.panelDesktops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktops.Location = new System.Drawing.Point(0, 64);
            this.panelDesktops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktops.Name = "panelDesktops";
            this.panelDesktops.Size = new System.Drawing.Size(871, 915);
            this.panelDesktops.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Green_Food_Instagram_Post_Template;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 915);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(68)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 8);
            this.panel4.TabIndex = 1;
            // 
            // panelTitlbar
            // 
            this.panelTitlbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitlbar.Controls.Add(this.guna2ControlBox3);
            this.panelTitlbar.Controls.Add(this.guna2ControlBox2);
            this.panelTitlbar.Controls.Add(this.guna2ControlBox1);
            this.panelTitlbar.Controls.Add(this.lblTitleChildForm);
            this.panelTitlbar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitlbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlbar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitlbar.Name = "panelTitlbar";
            this.panelTitlbar.Size = new System.Drawing.Size(871, 56);
            this.panelTitlbar.TabIndex = 0;
            this.panelTitlbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlbar_MouseDown);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.guna2ControlBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox3.Location = new System.Drawing.Point(804, 2);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 25);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox2.Location = new System.Drawing.Point(769, 2);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 25);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.guna2ControlBox1.Location = new System.Drawing.Point(839, 2);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 25);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(55, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 31;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 10);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(34, 31);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.menuTaiKhoan.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThongTinNV,
            this.toolStripSeparator1,
            this.itemDoiMatKhau,
            this.toolStripSeparator2});
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(222, 80);
            // 
            // itemThongTinNV
            // 
            this.itemThongTinNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.itemThongTinNV.Image = global::GUI.Properties.Resources.images;
            this.itemThongTinNV.Name = "itemThongTinNV";
            this.itemThongTinNV.Size = new System.Drawing.Size(221, 32);
            this.itemThongTinNV.Text = "Hồ sơ nhân viên";
            this.itemThongTinNV.Click += new System.EventHandler(this.itemThongTinNV_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // itemDoiMatKhau
            // 
            this.itemDoiMatKhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.itemDoiMatKhau.Image = global::GUI.Properties.Resources.images;
            this.itemDoiMatKhau.Name = "itemDoiMatKhau";
            this.itemDoiMatKhau.Size = new System.Drawing.Size(221, 32);
            this.itemDoiMatKhau.Text = "Đổi mật khẩu";
            this.itemDoiMatKhau.Click += new System.EventHandler(this.itemDoiMatKhau_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // FrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 979);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrMain_FormClosing);
            this.Load += new System.EventHandler(this.FrMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelDesktops.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitlbar.ResumeLayout(false);
            this.panelTitlbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.menuTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDangxuat;
        private FontAwesome.Sharp.IconButton btnTaikhoan;
        private FontAwesome.Sharp.IconButton btnKhachhang;
        private FontAwesome.Sharp.IconButton btnSanpham;
        private FontAwesome.Sharp.IconButton btnThongke;
        private FontAwesome.Sharp.IconButton btnNhanvien;
        private Panel panel3;
        private PictureBox panelHome;
        private Panel panel2;
        private Panel panelDesktops;
        private Panel panel4;
        private Panel panelTitlbar;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ContextMenuStrip menuTaiKhoan;
        private ToolStripMenuItem itemThongTinNV;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem itemDoiMatKhau;
        private ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconButton btnTaoQR;
        private Label lblEmail;
        // private System.Windows.Forms.ContextMenuStrip menuTaiKhoan;
    }
}