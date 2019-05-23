using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace golden_section
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Sven svan = new Sven();
        GolsSec gold = new GolsSec();
        private void Elbutton_Click(object sender, EventArgs e)
        {
            Elbutton.Text = Convert.ToString(svan.ActFunc(gold.GolsSe()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
