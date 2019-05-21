using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1SvenKestner
{
    public partial class Form1 : Form
    {
        Sven svan = new Sven();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
           
            labeliusOutPut.Text = "Svan = " + svan.TempFunc(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeliusOutPut.Text =  svan.SvenFunc();
        }
    }
}
