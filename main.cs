using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DataBase
{
    public partial class main : Form
    {
        
        public main()
        {
            InitializeComponent();
        }

        private void Bs_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void Get_ID_Click(object sender, EventArgs e)
        {
            getid g = new getid();
            g.Show();
            this.Close();
        }
    }
}
