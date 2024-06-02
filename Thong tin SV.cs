using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForm
{
    public partial class frmTTSV : Form
    {
        public frmTTSV()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
        #region Xem thông tin SV
        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            txtHoDem.Clear();
            txtHoDem.Focus();
            txtTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            if (rdNam.Checked == false)
                rdNam.Checked = true;

            chkTiengAnh.Checked = false;
            chkTiengNhat.Checked = false;

            cboQueQuan.SelectedIndex = 0;
            lstDSMH.ClearSelected();
        }
        #endregion

        private void btnTTSV_Click(object sender, EventArgs e)
        {

            string ht = txtHoDem.Text + " " + txtTen.Text;

            string ns = dtpNgaySinh.Text; //dtpNgaySinh.Value.ToString;

            string gt = rdNam.Checked == true ? "Nam" : "Nữ";

            string nn = "";

            if (chkTiengAnh.Checked == true)
                nn = chkTiengAnh.Text;
            if (chkTiengNhat.Checked == true)
                nn = nn + "," + chkTiengNhat.Text;

            string qq = cboQueQuan.SelectedItem.ToString();   //cboQueQuan.Text;

            string dsmh = "";
            foreach (var mh in lstDSMH.SelectedItems)
                dsmh = dsmh + "\n" + mh;

            string st = @"Họ và Tên: " + ht +
                         "\nNgày sinh:" + ns +
                         "\n Giới  tính: " + gt +
                         "\n Ngoại ngữ: " + nn +
                         "\n Quê quán: " + qq +
                         "\n DS môn học: " + dsmh;

            MessageBox.Show(st);
        }

        private void btnLayanh_Click(object sender, EventArgs e)
        {
            oFileDialog1.Filter = "Tập tin ảnh  | *.png; *.jpg| File tùy ý  (*.*)|*.*";
            if(oFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(oFileDialog1.FileName);
            }
        }
    }
}
    
