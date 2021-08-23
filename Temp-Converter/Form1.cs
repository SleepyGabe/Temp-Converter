using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTFI1B_Parinas_TempConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CelsiusConv_Click(object sender, EventArgs e)
        {
            //1.) Declare 2 Double type variables
            decimal CelsIn, FhnOut, Fhn;
            //2.) Initialize variables to 0
            CelsIn = 0M;
            //3.) get inputs from user
            CelsIn = decimal.Parse(txtIn.Text);
            //4.) Compute for temp in Fahrenheit (Rounded off)
            FhnOut = (CelsIn * 9) / 5 + 32;
            Fhn = Math.Round(FhnOut, 2);
            //5.) Display output
            txtOut.Text = Fhn.ToString();
        }

        private void FhnConv_Click(object sender, EventArgs e)
        {
            //1.) declare 2 double type variables
            decimal FhnIn, CelsOut, Cels;
            //2.) Initialize variables to 0
            FhnIn = CelsOut = 0M;
            //3.) get input from user
            FhnIn = decimal.Parse(txtIn.Text);
            //4.) compute for temp in celsius (Rounded off)
            CelsOut = (FhnIn - 32) * 5 / 9;
            Cels = Math.Round(CelsOut, 2);
            //5.) Display output to user
            txtOut.Text = Cels.ToString();
        }
    }
}
