using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılı_ortlaması_hesaplama_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHespla_Click(object sender, EventArgs e)
        {
            int not1 , not2, not3;
            double SONUC;

            not1 =  Convert.ToInt32(txtNot1.Text);
            not2 = Convert.ToInt32(txtNot2.Text);
            not3 = Convert.ToInt32(txtNot3.Text);

            SONUC =(not1 + not2 + not3);

            lblHplma.Text = SONUC.ToString();
        }
    }
}
