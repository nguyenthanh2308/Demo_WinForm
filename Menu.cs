using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demo_WinForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void thôatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmTTSV f = new frmTTSV();
            f.MdiParent = this;
                f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFileDialog = new SaveFileDialog();
            sFileDialog.Filter = "Save as.txt|*.txt";
            if (sFileDialog.ShowDialog() == DialogResult.OK) 
            {
                Stream stream = sFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(txtFile.Text);

                writer.Close();
                stream.Close();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFileDialog2 = new OpenFileDialog();
            //mo file 
            oFileDialog2.Filter = "Tập tin C#|*.cs";
            if(oFileDialog2.ShowDialog(this)== DialogResult.OK)
            {
                Stream stream = oFileDialog2.OpenFile();
                StreamReader reader = new StreamReader(stream);
                txtFile.Text = reader.ReadToEnd();
                reader.Close();
                stream.Close();
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.Font = txtFile.Font;
            font.Color = txtFile.ForeColor;
            if(font.ShowDialog()== DialogResult.OK)
            {
                txtFile.Font = font.Font;
                txtFile.ForeColor = font.Color;
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
            {
                txtFile.Clear();
                MessageBox.Show("Da xoa  thanh cong");
            }
        }
    }
}
