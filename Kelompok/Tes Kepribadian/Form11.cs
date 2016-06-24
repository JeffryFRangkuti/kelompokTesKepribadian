using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tes_Kepribadian
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.a = Convert.ToInt32(+Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.b = Convert.ToInt32(+Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Program.c = Convert.ToInt32(+Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Program.d = Convert.ToInt32(+Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah + Program.penambah);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form x = new Form12();
            x.Show();
            this.Hide();
        }

    }
}
