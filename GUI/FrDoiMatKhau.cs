using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class FrDoiMatKhau : Form
    {


        public FrDoiMatKhau(string email)
        {
            InitializeComponent();
            txtEmail.Text = email;
        }
        FrNhanvien nhanvien = new FrNhanvien();
        private bool isSuccess = false;

        public bool getSuccess
        {
            get { return isSuccess; }
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != "")
            {
                if (txtMatKhauMoi.Text == txtMatKhauMoi2.Text)
                {
   
                    BLL_NhanVien nv = new BLL_NhanVien();
                    if (nv.QuenMatKhau(txtEmail.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng xuất và nhập lại", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isSuccess = true;
                     
                        
                        Close();
                       
                        


                    }
                    else MessageBox.Show("Mật khẩu cũ không đúng rồi nhập lại đi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Mật khẩu mới không trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
