using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_Canabis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textboxmatkhau.Text== "admin" && textboxusername.Text== "admin")
            {
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
