using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using BarcodeLib;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using System.Drawing.Drawing2D;
using DTO;
using BLL;


namespace GUI
{
    public partial class FrTaoQR : Form
    {
        BLL_NhanVien busNV = new BLL_NhanVien();
        //BarcodeLib.Barcode code128;
        public FrTaoQR()
        {
            InitializeComponent();
            //code128 = new Barcode();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
          
            var qrcode_text = $"{txtMatkhau.Text.Trim()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.images, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pictureBox_QRCode.Image = bitmap;
        }
        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }
        private void msgBox(string message, bool isError = false)
        {
            if (isError)
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (txtEmail.Text != "" && txtMatkhau.Text != "")
            //{   
                
            //    DTO_NhanVien nhanvien = new DTO_NhanVien(txtEmail.Text);
            //    //if (busNV.DangNhapQR(nhanvien))
            //    //{
            //    //    msgBox("Thêm khách hàng thành công!");
                    
            //    //}
            //    //else
            //    //    msgBox("Thêm khách hàng không thành công", true);
            //}
            //else
            //    msgBox("Vui lòng kiểm tra lại dữ liệu", true);
        }
    }
}
