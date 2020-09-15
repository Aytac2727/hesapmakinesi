using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double reqem1 =0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 + reqem2;
            result.Text = Convert.ToString(netice);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 - reqem2;
            result.Text = Convert.ToString(netice);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 / reqem2;
            result.Text = Convert.ToString(netice);
        }

        private void btnMut_Click(object sender, EventArgs e)
        {
            double reqem1 = 0, reqem2 = 0, netice = 0;
            reqem1 = Convert.ToDouble(textBox1.Text);
            reqem2 = Convert.ToDouble(textBox2.Text);
            netice = reqem1 * reqem2;
            result.Text = Convert.ToString(netice);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
