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
    public partial class Frmformchinh : Form
    {
        public Frmformchinh()
        {
            InitializeComponent();
        }

        private void maytinh_Click(object sender, EventArgs e)
        {
            frmMayTinh f = new frmMayTinh();
             f.Show();
            f.Owner = this;            
        }

        private void Frmformchinh_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
