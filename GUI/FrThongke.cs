using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace GUI
{
    public partial class FrThongke : Form
    {
        public FrThongke()
        {
            InitializeComponent();
        }

        private void FrThongKe_Load(object sender, EventArgs e)
        {
            BLL.BLL_Hang bllHang = new BLL.BLL_Hang();
            dataGridViewNhapKho.DataSource = bllHang.thongKeSP();
            dataGridViewTonKho.DataSource = bllHang.thongKeTonKho();
            designView();
        }

        void designView()
        {
            dataGridViewTonKho.Columns[0].HeaderText = "Tên hàng";
            dataGridViewTonKho.Columns[1].HeaderText = "Số lượng";
           // dataGridViewTonKho.Columns[2].HeaderText = "email";
            dataGridViewTonKho.Columns[0].DividerWidth = 2;
            //dataGridViewTonKho.Columns[1].DividerWidth = 2;
            //dataGridViewTonKho.Columns[2].DividerWidth = 2;
            dataGridViewNhapKho.Columns[0].HeaderText = "Mã nhân viên";
            dataGridViewNhapKho.Columns[1].HeaderText = "Tên nhân viên";
            dataGridViewNhapKho.Columns[2].HeaderText = "Số lượng sản phẩm nhập";
            dataGridViewNhapKho.Columns[0].DividerWidth = 2;
            dataGridViewNhapKho.Columns[1].DividerWidth = 2;
            dataGridViewNhapKho.Columns[2].DividerWidth = 2;

        }

        private void dataGridViewTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
