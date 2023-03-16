using FontAwesome.Sharp;
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
using DTO;
using BLL;


namespace GUI
{
    public partial class FrLogin : Form
    {
        private bool isSuccess = false;
        public string getEmail
        {
            get
            {
                return txtEmail.Text;
            }
        }
        public bool getSuccess
        {
            get { return isSuccess; }
        }
        private Panel leftBorderBtn;
        DTO_NhanVien taikhoan = new DTO_NhanVien();
        BLL_NhanVien taikhoanBLL = new BLL_NhanVien();
        public FrLogin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelLogin.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnDangNhapQR_Click(object sender, EventArgs e)
        {
            //FrLoginQR frLoginQR = new FrLoginQR();
            //frLoginQR.ShowDialog();
            ////frLoginQR.Show();
            ////this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtMatKhau.Text != "")
            {
                BLL_NhanVien nv = new BLL_NhanVien();
                if (nv.DangNhap(txtEmail.Text, txtMatKhau.Text))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    isSuccess = true;
                    //FrMain frMain = new FrMain();
                    //frMain.Show();
                    Properties.Settings.Default.isSave = chkGhiNho.Checked;
                    if (chkGhiNho.Checked)
                    {
                        Properties.Settings.Default.Email = txtEmail.Text;
                        Properties.Settings.Default.Password = txtMatKhau.Text;

                    }
                    Properties.Settings.Default.Save();
                    Close();

                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                    txtEmail.Text = "";
                    txtMatKhau.Text = "";
                    txtEmail.Focus();
                }
            }
            else
                MessageBox.Show("Thiếu trường thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    msgBox("Thiếu trường thông tin!", true);
        }

        private void FrLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtEmail.Text = Properties.Settings.Default.Email;
                txtMatKhau.Text = Properties.Settings.Default.Password;
                chkGhiNho.Checked = true;
                btnDangNhap.Focus();
            }
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            if (txtEmail.Text != "")
            {

                // check email 
                BLL_NhanVien busNV = new BLL_NhanVien();
                if (busNV.checkEmail(txtEmail.Text))
                {

                    string password = busNV.getPassword();

                    if (busNV.updateMatKhau(txtEmail.Text, password))
                    {
                        SendMail load = new SendMail(txtEmail.Text, password, true);
                        load.ShowDialog();
                        MessageBox.Show(load.getResult, "Thông báo");
                    }
                    else
                        MessageBox.Show("Không thực hiện được", "Thông báo");


                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
