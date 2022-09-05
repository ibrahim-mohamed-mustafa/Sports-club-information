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
    public partial class getid : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;

        public getid()
        {
            InitializeComponent();
        }

        private void Get_T_ID_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetTeamID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("teamname", Team_Name.Text);
            cmd.Parameters.Add("id", OracleDbType.Int64,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Team_id.Text = dr[0].ToString();

                

            }
          /*  try
            {
                Team_id.Text = cmd.Parameters["id"].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Invalid Team Name");
            }*/


        }

        private void getid_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
