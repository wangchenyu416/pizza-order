using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Npgsql;
using NpgsqlTypes;

namespace PizzaWang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sc = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;";
                NpgsqlConnection con = new NpgsqlConnection(sc);
                con.Open();

                //string query = "INSERT INTO customer (cno,name, address,tele_num,password) VALUES ('16','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";

                string query = "select create_new_user_and_new_role('" + textBox1.Text +"','"+textBox4.Text+"')";
                    
                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                ncmd.ExecuteNonQuery();

                //int result = ((int)ncmd.ExecuteScalar());

                //MessageBox.Show("...");
                con.Close();
              
                this.Hide();
                Form4 f4 = new Form4(sc);
                f4.Show();
            }
            catch (Exception )
            {
               // something went wrong, and you wanna know why
                MessageBox.Show("problem hmm"/*msg.ToString()*/);
                throw;
            }
            
        }
         
    }
}
