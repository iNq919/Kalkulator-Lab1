using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        int Val1, Val2, Result;
        string op = "";
        private void btnClear_Click(object sender, EventArgs e)
        {
            wynik.Text = "0";
            Val1 = 0;
            Val2 = 0;
            op = "";
        }

        public Kalkulator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Val2 = int.Parse(wynik.Text);
            if (op=="+")
            {
                Result = Val1 + Val2;
            }
            else if (op=="-")
            {
                Result = Val1 - Val2;
            }
            else if(op=="*")
            {
                Result = Val1 * Val2;
            }
            else if(op=="/")
            {
                Result = Val1 / Val2;
            }
            wynik.Text = Result.ToString();
        }

        private void DoNumClick(object sender,EventArgs e)
        {
            Button b = sender as Button;
            int v = int.Parse(b.Text);
            int Val = int.Parse(wynik.Text);
            Val = Val * 10 + v;
            wynik.Text = Val.ToString();
        }
        private void DoOperatorClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            op = b.Text;
            Val1 = int.Parse(wynik.Text);
            wynik.Text = "0";

        }
    }
}
