using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BLL;
namespace GUI
{
    public partial class SendMail : Form
    {
        public SendMail(string email, string pass, bool isUpdate = false)
        {
            InitializeComponent();
            this.email = email;
            this.password = pass;
            this.isUpdate = isUpdate;
        }

        private string result = "";
        public string getResult { get { return result; } }
        private string email; // email cần gửi tin
        private string password; // mật khẩu đăng nhập phần mềm
        private bool isUpdate;
        private void SendMail_Load(object sender, EventArgs e)
        {
            Thread r = new Thread(send);
            r.IsBackground = true;
            r.Start();
        }
        private void send()
        {
           
            //string loginEmail = "khalyumtkg2@gmail.com";
            //string loginPassword = "saunzzscmdwuxemg";
            string loginEmail = "khalyhaisan2022@gmail.com";
            string loginPassword = "qebyimmsmrlespsi";
            BLL_Mail mail = new BLL_Mail(loginEmail, loginPassword); // tạo đối tượng để gửi mail truyền tk,pass để login
            result = mail.sendMail(email, password, isUpdate); // nếu là cập nhật mật khẩu thì true, còn nếu là mật khẩu thì false;
            pictureBox1.Invoke(new Action(() => Close()));
        }
    }
}
