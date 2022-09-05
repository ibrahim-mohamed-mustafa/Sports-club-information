using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project_DataBase
{
    public partial class Form2 : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;

        public Form2()
        {
            InitializeComponent();
        }

        private void GetID_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=ORCL;User Id=scott;Password=tiger;";
            string cmdstr = "";
            



            if (cmb.SelectedItem.ToString() == "Player Information") 
                cmdstr = "select * from PLAYER ";
            if (cmb.SelectedItem.ToString() == "Coach Information")
                cmdstr = "select * from COACH ";
            if (cmb.SelectedItem.ToString() == "Team Information")
                cmdstr = "select * from TEAM ";
            if (cmb.SelectedItem.ToString() == "Competition Information")
                cmdstr = "select * from COMPETITION ";


             adapter = new OracleDataAdapter(cmdstr, constr);
             ds = new DataSet();
             adapter.Fill(ds);
             dataGridView1.DataSource = ds.Tables[0];

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

     

        private void Save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }
    }
}
