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
            int a = int.Parse(lbA.Text);
            int b = int.Parse(lbB.Text);
            Calculation c = new Calculation(a, b);

            lbC.Text = c.Execute("+").ToString();
            //if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            //{
            //    double a = double.Parse(lbA.Text);
            //    double b = double.Parse(lbB.Text);
            //    double c = a + b;
            //    lbC.Text = c.ToString();
            //}


        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbA.Text);
            int b = int.Parse(lbB.Text);
            Calculation c = new Calculation(a, b);

            lbC.Text = c.Execute("-").ToString();
            //if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            //{
            //    double a = double.Parse(lbA.Text);
            //    double b = double.Parse(lbB.Text);
            //    double c = a - b;
            //    lbC.Text = c.ToString();
            //}
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbA.Text);
            int b = int.Parse(lbB.Text);
            Calculation c = new Calculation(a, b);

            lbC.Text = c.Execute("/").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbA.Text);
            int b = int.Parse(lbB.Text);
            Calculation c = new Calculation(a, b);

            lbC.Text = c.Execute("*").ToString();
        }
    }
}

