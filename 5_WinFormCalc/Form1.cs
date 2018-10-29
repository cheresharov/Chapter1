using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_WinFormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            boxMessage.Text = "Hello World Mam";
            boxMessage.AppendText(" from Mireal!" + Environment.NewLine);

            boxMessage.AppendText("And from Aline also!");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            boxMessage.Text = "";
        }
    }
}
