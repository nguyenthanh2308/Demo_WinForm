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
    public partial class Tabcontrol : Form
    {
        public Tabcontrol()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int x = int.Parse(numericUpDown1.Value.ToString());
            MessageBox.Show("Số răng trám " + x );
        }
    }
}
