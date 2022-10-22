using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            {
                double a = double.Parse(lbA.Text);
                double b = double.Parse(lbB.Text);
                double c = a + b;
                lbC.Text = c.ToString();
            }
                

        }
    }
}
