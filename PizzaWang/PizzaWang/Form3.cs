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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

             //allpasswords = textBox2.Text;
            
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
                   
                    
                        string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                        "User Id={0};Password={1};Database=postgres;",
                        textBox1.Text, textBox2.Text);

                        NpgsqlConnection con = new NpgsqlConnection(connstring);
                        con.Open();
                        string query = "select count(*) from information_schema.role_table_grants where grantee = 'wang' and table_name='pizza' and privilege_type='DELETE';";
                        //string query = "select count(*) from customer;";


                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        Int64 count = (Int64)ncmd.ExecuteScalar();
                        if (count == 1)
                        {
                            MessageBox.Show("Welecome   Admin :" + textBox1.Text + "   back !");
                            this.Hide();
                            Form5 f5 = new Form5(connstring);
                            f5.Show();
                        }
                        else
                        {
                            MessageBox.Show("Welecome  :" + textBox1.Text + "   back !");
                            this.Hide();
                            Form4 f4 = new Form4(connstring);
                            f4.Show();
                        }


                        //string query = "INSERT INTO customer (cno,name, address,tele_num,password) VALUES ('15','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";


                        // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        // ncmd.ExecuteNonQuery();

                        //int result = ((int)ncmd.ExecuteScalar());
                      //  MessageBox.Show("Welecome   Admin :" + textBox1.Text + "   back !");

                        //this.Hide();
                        //Form4 f4 = new Form4();
                        //f4.Show();

                        //con.Close();
                    
                    
                    
                        //string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                        //"User Id={0};Password={1};Database=postgres;",
                        //textBox1.Text, textBox2.Text);

                        //NpgsqlConnection con = new NpgsqlConnection(connstring);
                        //con.Open();

                        con.Close();

                        //this.Hide();
                        //Form4 f4 = new Form4();
                        //f4.Show();
                    

                }
                catch (Exception)
                {
                    // something went wrong, and you wanna know why
                    MessageBox.Show("First time here at PizzaWang ?  Please register first! ");

                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                    //throw;
                }
            
           // ----------------------------------------------------------------
          /*  if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();
            }
            else
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
           */
        }
    }
}
