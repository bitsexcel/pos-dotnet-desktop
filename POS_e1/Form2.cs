using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_e1
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
           

        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();

        }
    }
}
