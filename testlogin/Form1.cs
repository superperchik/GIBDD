using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testlogin
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = txtUser.Text;
            string psw = txtPass.Text;
            con = new OleDbConnection("server=localhost\\SQLEXPRESS;Trusted_Connection=Yes;Database=GIBDD;");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM User where Login='" + txtUser.Text + "' AND Password='" + txtPass.Text + "'";
            cmd.CommandText = str;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Добро пожаловать " + txtUser.Text);
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

            con.Close();
        }
    }
}
