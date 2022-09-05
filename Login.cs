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
    public partial class Login : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection con;
        OracleDataAdapter orada;
        OracleCommand com;


        string str;

        DataTable dt;

        int RowCount;

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

            con = new OracleConnection(ordb);
            con.Open();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           // con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into  LOGIN  values(:id,:pass )";

            cmd.Parameters.Add("id", user.Text);
            cmd.Parameters.Add("pass", passw.Text);
            
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("Sign Up Successed");
            }
            con.Close();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
          
            string UserName = user.Text.Trim();

            string Password = passw.Text.Trim();

            str = "SELECT * FROM Login";

            com = new OracleCommand(str);

            orada = new OracleDataAdapter(com.CommandText, con);

            dt = new DataTable();

            orada.Fill(dt);

            RowCount = dt.Rows.Count;
            int c = 0;

            for (int i = 0; i < RowCount; i++)

            {

                UserName = dt.Rows[i]["USER"].ToString();

                Password = dt.Rows[i]["PASSOWRD"].ToString();

                if (UserName == user.Text && Password == passw.Text)

                {
                    c++;

                    MessageBox.Show("Login sucess Welcome to Homepage");

                    main m = new main();
                    m.Show();
                    break;
                

                }

               

            }

            
            if (c == 0 )
            {

                MessageBox.Show("Invalid Login please check username and password");

            }

            con.Close();
        }

      
    }
    }

