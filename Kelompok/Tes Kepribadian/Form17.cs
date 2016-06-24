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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            label1.Text = "Hasil nilai A anda   "+Program.a.ToString()+"     SANGUINIS ";
            label2.Text = "Hasil nilai B anda   " + Program.b.ToString() + "     KOLERIS ";
            label3.Text = "Hasil nilai C anda   " + Program.c.ToString() + "     MELANKOLIS ";
            label4.Text = "Hasil nilai D anda   " + Program.d.ToString() + "     PLEGMATIS ";
            label5.Text = "Nilai tertinggi adalah jenis kepridian anda..";
        }
    }
}
