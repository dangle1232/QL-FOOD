using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class FrMain : Form
    {
        public string email;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        BLL_NhanVien busNV = new BLL_NhanVien();
     
        public FrMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktops.Controls.Add(childForm);
            panelDesktops.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Events
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrNhanvien());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrThongke());
        }

        private void btbSanpham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
           // FrHang frHang = new FrHang();
            OpenChildForm(new FrHang(email));
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FrKhachhang(email));
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            //menuTaiKhoan.Show(panelMenu, new Point(206, 405));
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new FrTaiKhoan());
            menuTaiKhoan.Show(panelMenu, new Point(206, 405));
        }
        
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            if (btnDangxuat.Text == "Đăng nhập")
            {

                resetValue(false);
                using (FrLogin flogin = new FrLogin())
                {
                    flogin.ShowDialog();
                    
                    if (flogin.getSuccess)
                    {
                        // đã đăng nhập thành công
                        
                        email = flogin.getEmail;
                        resetValue();
                        btnDangxuat.Text = "Đăng xuất";
                        
                        
                        btnDangxuat.IconChar = FontAwesome.Sharp.IconChar.SignOut;
                        
                    }//đăng nhập không thành công thì không làm gì
                }
            }
            else
            {
                panelDesktops.Controls.Clear();
                resetValue(false);
                
                lblEmail.Text = "Đăng nhập để sử dụng";
                btnDangxuat.Text = "Đăng nhập";
                btnDangxuat.IconChar = FontAwesome.Sharp.IconChar.SignIn;


            }
        }
        private void resetValue(bool isVisible = true)
        {
            lblEmail.Text = "Chào nhân viên \n" + email;
            btnNhanvien.Visible = isVisible;
            btnKhachhang.Visible = isVisible;
            btnSanpham.Visible = isVisible;
            btnThongke.Visible = isVisible;
            btnTaikhoan.Visible = isVisible;
           // btnTaoQR.Visible = isVisible;
            // kiểm tra vai tro | true = quản trị , false = nhân viên thường 
            if (!busNV.LayVaiTro(email))
            {
                btnNhanvien.Visible = false;
                btnThongke.Visible = false;
                btnTaoQR.Visible = false;
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnTaikhoan_MouseHover(object sender, EventArgs e)
        {
            menuTaiKhoan.Show(panelMenu, new Point(206, 405));
        }

        private void FrMain_Load(object sender, EventArgs e)
        {
            //menuHuongDan.Cursor = Cursors.Hand;
           // lblEmail.Text = "Đăng nhập để sử dụng";
            menuTaiKhoan.Cursor = Cursors.Hand;
            resetValue(false);
        }

        private void btnTaoQR_Click(object sender, EventArgs e)
        {
            // FrTaoQR frmThongTin = new FrTaiKhoan;
            // FrTaoQR.ShowDialog();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrTaoQR());

        }

        private void itemThongTinNV_Click(object sender, EventArgs e)
        {
            //FrThongtinnhanvien frmThongTin = new FrThongtinnhanvien(email);
            //frmThongTin.ShowDialog();
            //ActivateButton(sender, RGBColors.color2);
            // OpenChildForm(new FrThongtinnhanvien());
            OpenChildForm(new FrThongtinnhanvien(email));
        }

        private void itemDoiMatKhau_Click(object sender, EventArgs e)
        {
            //FrDoiMatKhau frMatkhau = new FrDoiMatKhau();
            //frMatkhau.ShowDialog();
            OpenChildForm(new FrDoiMatKhau(email));
        }

        private void FrMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //private void guna2ControlBox1_Click(object sender, EventArgs e)
        //{

        //}
    }
}