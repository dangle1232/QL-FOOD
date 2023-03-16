using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using DTO;
using BLL;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace GUI
{
   //FrHang hang = new FrHang();
    public partial class FrThanhToan : Form
    {
        //private string email;
        BLL_Hang busHang = new BLL_Hang();
        DTO_Hang dtohang = new DTO_Hang();
        //FrHang frHang = new FrHang(email);
        private void frHang(string email)
        {
            FrHang hang = new FrHang(email);
        }
    //   private static string email;
       // FrHang.
        public FrThanhToan()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool checkIsNummber(string text)
        {
            return int.TryParse(text, out int s);
        }
        private bool isValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitlbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_pay_Click(object sender, EventArgs e)
        {
            //FrHang hang = new FrHang();
          //  txtsotien = hang. * dtohang.soLuong;
          //frHang.txtsotien
          //DTO
                var qrcode_text = $"2|99|{txtphone.Text.Trim()}|{txtname.Text.Trim()}|{txtemail.Text.Trim()}|0|0|{txtsotien.Text.Trim()}";
            if (!checkIsNummber(txtphone.Text) || !checkIsNummber(txtsotien.Text))
                msgBox("Vui lòng nhập chữ số!", true);
            //else if (txtname.Text == "")
            //   msgBox("Thiếu trường thông tin!", true);
            //if (!isValidEmail(txtemail.Text))
            //    msgBox("Email không đúng định dạng!", true);
            if (txtphone.Text != "" && txtname.Text != "" && txtemail.Text != "" && txtsotien.Text != "")
            {
                if (checkIsNummber(txtphone.Text) || checkIsNummber(txtsotien.Text))
                {
                    if (isValidEmail(txtemail.Text))
                        {
                        BarcodeWriter barcodeWriter = new BarcodeWriter();
                        EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                        encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                        barcodeWriter.Renderer = new BitmapRenderer();
                        barcodeWriter.Options = encodingOptions;
                        barcodeWriter.Format = BarcodeFormat.QR_CODE;
                        Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                        Bitmap logo = resizeImage(Properties.Resources.logo_momo, 64, 64) as Bitmap;
                        Graphics g = Graphics.FromImage(bitmap);
                        g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                        pictureBox_QRCode.Image = bitmap;
                        }
                        else
                            msgBox("Email không đúng định dạng!", true);
                }
                else
                    msgBox("Vui lòng nhập chữ số!", true);
            }
            else
                msgBox("Thiếu trường thông tin!", true);
                
            
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
    }
}
