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
    public partial class Form1 : Form
    {

        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;


        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "SELECT FIRSTNAME, LASTNAME, PLAYERPOSITION, PLAYERAGE FROM PLAYER WHERE PLAYERID =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_ID.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FN.Text = dr["FIRSTNAME"].ToString();
                LN.Text = dr["LASTNAME"].ToString();
                PP.Text = dr["PLAYERPOSITION"].ToString();
                PA.Text = dr["PLAYERAGE"].ToString();

            }
            dr.Close();

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into PLAYER ( PLAYERID ,FIRSTNAME , LASTNAME , PLAYERPOSITION,PLAYERAGE) values(:id,:Fname,:Lname,:Pposition,:Page )";

             cmd.Parameters.Add("id", cmb_ID.Text);
            cmd.Parameters.Add("Fname", FN.Text);
            cmd.Parameters.Add("Lname", LN.Text);
            cmd.Parameters.Add("Pposition", PP.Text);
            cmd.Parameters.Add("Page", PA.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Player is Added");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
