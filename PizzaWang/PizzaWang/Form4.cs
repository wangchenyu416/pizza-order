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
    public partial class Form4 : Form
    {
        private string connstring;
        
        public Form4(string cs)
        {
            InitializeComponent();
            connstring = cs;

            try
            {
               
                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select distinct product_type from pizza join product_table using(prod_id);";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);


                NpgsqlDataReader dr = ncmd.ExecuteReader();

                comboBox1.Items.Clear();
                while (dr.Read())
                {

                    comboBox1.Items.Add(dr["product_type"]);
                    comboBox4.Items.Add(dr["product_type"]);
                    comboBox6.Items.Add(dr["product_type"]);

                }
  
                dr.Close();

                dr.Dispose();


                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //   // Form3 f3 = new Form3();
            //    //string connstring = "Server=127.0.0.1;Port=5432; User Id=tomas;Password=tomas;Database=postgres";

            //    NpgsqlConnection con = new NpgsqlConnection(connstring);
            //    con.Open();
                
            //    string query = "select distinct product_type from pizza join product_table using(prod_id);";


            //    NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                
            //    NpgsqlDataReader dr = ncmd.ExecuteReader();

            //    comboBox1.Items.Clear();
            //    while (dr.Read())
            //    {

            //        comboBox1.Items.Add(dr["product_type"]);

            //    }
            //    //---------------------------------------------

            //    //NpgsqlCommand cmd = new NpgsqlCommand("select count(*) from pizza", con);
            //    //Int64 count = (Int64)cmd.ExecuteScalar();
            //    // select * from information_schema.role_table_grants where grantee = 'wang' and table_name='pizza' and privilege_type='DELETE';

            //    //MessageBox.Show(string.Format("pizzas: {0}", count));
            //   // Console.Write("{0}\n", count);
            //   dr.Close();
                
            //   dr.Dispose();


               

                
            //    con.Close();
            //}
            //catch (Exception msg)
            //{
            //    // something went wrong, and you wanna know why
            //    MessageBox.Show(msg.ToString());
            //    throw;
            //}
//-------------------------------------------------------------------------------------------------------------------------------------------------------------
            //try
            //{
            //    //string connstring = "Server=127.0.0.1;Port=5432; User Id=tomas;Password=tomas;Database=postgres";

            //    NpgsqlConnection con = new NpgsqlConnection(connstring);
            //    con.Open();

            //    string query = "select pizza_size from pizza join product_table using(prod_id) where product_type = '"+comboBox1.Text+"';";


            //    NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

            //    NpgsqlDataReader dr = ncmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        comboBox2.Items.Add(dr["pizza_size"]);

            //    }
            //    dr.Close();
            //    dr.Dispose();



            //    con.Close();
            //}
            //catch (Exception msg)
            //{
            //    // something went wrong, and you wanna know why
            //    MessageBox.Show(msg.ToString());
            //    throw;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

             try
            {
                //Form3 f3 = new Form3();
                //f3.Show();

                //MessageBox.Show(string.Format("pizzas: {0}", f3));


                //string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                //         "User Id={0};Password={1};Database=postgres;",
                //         f3.textBox1.Text, f3.textBox2.Text);
               // MessageBox.Show(connstring);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select distinct pizza_type from pizza order by pizza_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox4.Items.Add(dr["pizza_type"]);
                    
                }
                dr.Close();
                dr.Dispose();
               

                
                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
//-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                //Form3 f3 = new Form3();
                //string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                //         "User Id={0};Password={1};Database=postgres;",
                //         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza order by pizza_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_type from pizza order by pizza_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox6.Items.Add(dr["pizza_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza order by pizza_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox5.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_type from pizza order by pizza_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox8.Items.Add(dr["pizza_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza order by pizza_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox7.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_type from pasta order by pasta_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox10.Items.Add(dr["pasta_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_size from pasta order by pasta_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox9.Items.Add(dr["pasta_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_type from pasta order by pasta_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox12.Items.Add(dr["pasta_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_size from pasta order by pasta_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox11.Items.Add(dr["pasta_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_type from pasta order by pasta_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox14.Items.Add(dr["pasta_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_size from pasta order by pasta_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox13.Items.Add(dr["pasta_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_type from pasta order by pasta_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox16.Items.Add(dr["pasta_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pasta_size from pasta order by pasta_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox15.Items.Add(dr["pasta_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select sauce_type from sauce order by sauce_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox18.Items.Add(dr["sauce_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select sauce_type from sauce order by sauce_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox17.Items.Add(dr["sauce_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select sauce_type from sauce order by sauce_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox19.Items.Add(dr["sauce_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select sauce_type from sauce order by sauce_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox20.Items.Add(dr["sauce_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select dessert_type from dessert order by dessert_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox21.Items.Add(dr["dessert_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select dessert_type from dessert order by dessert_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox22.Items.Add(dr["dessert_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select dessert_type from dessert order by dessert_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox23.Items.Add(dr["dessert_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select dessert_type from dessert order by dessert_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox24.Items.Add(dr["dessert_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_type from drink order by drink_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox26.Items.Add(dr["drink_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_size from drink order by drink_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox25.Items.Add(dr["drink_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_type from drink order by drink_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox28.Items.Add(dr["drink_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_size from drink order by drink_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox27.Items.Add(dr["drink_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_type from drink order by drink_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox30.Items.Add(dr["drink_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_size from drink order by drink_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox29.Items.Add(dr["drink_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_type from drink order by drink_type asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox32.Items.Add(dr["drink_type"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                Form3 f3 = new Form3();
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                         "User Id={0};Password={1};Database=postgres;",
                         f3.textBox1.Text, f3.textBox2.Text);

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select drink_size from drink order by drink_size asc;";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox31.Items.Add(dr["drink_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label7.Text = comboBox1.Text;
            label8.Text = comboBox2.Text;
            if (numericUpDown1.Value == 0)
            {
                //do nothing
            }
            else label9.Text = numericUpDown1.Value.ToString();

            label10.Text = comboBox4.Text;
            label11.Text = comboBox3.Text;
            if (numericUpDown2.Value == 0)
            {
                //do nothing
            }
            else label12.Text = numericUpDown2.Value.ToString();

            label13.Text = comboBox6.Text;
            label14.Text = comboBox5.Text;
            if (numericUpDown3.Value == 0)
            {
                //do nothing
            }
            else label15.Text = numericUpDown3.Value.ToString();

            label16.Text = comboBox8.Text;
            label17.Text = comboBox7.Text;
            if (numericUpDown4.Value == 0)
            {
                //do nothing
            }
            else label18.Text = numericUpDown4.Value.ToString();

            //-----------------------------------------------

            label30.Text = comboBox10.Text;
            label29.Text = comboBox9.Text;
            if (numericUpDown5.Value == 0)
            {
                //do nothing
            }
            else label28.Text = numericUpDown5.Value.ToString();

            label25.Text = comboBox12.Text;
            label26.Text = comboBox11.Text;
            if (numericUpDown6.Value == 0)
            {
                //do nothing
            }
            else label27.Text = numericUpDown6.Value.ToString();

            label24.Text = comboBox14.Text;
            label23.Text = comboBox13.Text;
            if (numericUpDown7.Value == 0)
            {
                //do nothing
            }
            else label22.Text = numericUpDown7.Value.ToString();

            label21.Text = comboBox16.Text;
            label20.Text = comboBox15.Text;
            if (numericUpDown8.Value == 0)
            {
                //do nothing
            }
            else label19.Text = numericUpDown8.Value.ToString();

            //------------------------------------------------

            label54.Text = comboBox18.Text;
            if (numericUpDown9.Value == 0)
            {
                //do nothing
            }
            else label52.Text = numericUpDown9.Value.ToString();

            label49.Text = comboBox17.Text;
            if (numericUpDown10.Value == 0)
            {
                //do nothing
            }
            else label51.Text = numericUpDown10.Value.ToString();

            label48.Text = comboBox19.Text;
            if (numericUpDown11.Value == 0)
            {
                //do nothing
            }
            else label46.Text = numericUpDown11.Value.ToString();

            label45.Text = comboBox20.Text;
            if (numericUpDown12.Value == 0)
            {
                //do nothing
            }
            else label43.Text = numericUpDown12.Value.ToString();

            //-----------------------------------------------

            label42.Text = comboBox21.Text;
            if (numericUpDown13.Value == 0)
            {
                //do nothing
            }
            else label40.Text = numericUpDown13.Value.ToString();

            label37.Text = comboBox22.Text;
            if (numericUpDown14.Value == 0)
            {
                //do nothing
            }
            else label39.Text = numericUpDown14.Value.ToString();

            label36.Text = comboBox23.Text;
            if (numericUpDown15.Value == 0)
            {
                //do nothing
            }
            else label34.Text = numericUpDown15.Value.ToString();

            label33.Text = comboBox24.Text;
            if (numericUpDown16.Value == 0)
            {
                //do nothing
            }
            else label31.Text = numericUpDown16.Value.ToString();

            //----------------------------------------------

            label66.Text = comboBox26.Text;
            label65.Text = comboBox25.Text;
            if (numericUpDown17.Value == 0)
            {
                //do nothing
            }
            else label64.Text = numericUpDown17.Value.ToString();

            label61.Text = comboBox28.Text;
            label62.Text = comboBox27.Text;
            if (numericUpDown18.Value == 0)
            {
                //do nothing
            }
            else label63.Text = numericUpDown18.Value.ToString();

            label60.Text = comboBox30.Text;
            label59.Text = comboBox29.Text;

            if (numericUpDown19.Value == 0)
            {
                //do nothing
            }
            else label58.Text = numericUpDown19.Value.ToString();

            label57.Text = comboBox32.Text;
            label56.Text = comboBox31.Text;
            if (numericUpDown20.Value == 0)
            {
                //do nothing
            }
            else label55.Text = numericUpDown20.Value.ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string connstring = "Server=127.0.0.1;Port=5432; User Id=tomas;Password=tomas;Database=postgres";

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza join product_table using(prod_id) where product_type = '" + comboBox1.Text + "';";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                comboBox2.Items.Clear();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string connstring = "Server=127.0.0.1;Port=5432; User Id=tomas;Password=tomas;Database=postgres";

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza join product_table using(prod_id) where product_type = '" + comboBox4.Text + "';";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                comboBox3.Items.Clear();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string connstring = "Server=127.0.0.1;Port=5432; User Id=tomas;Password=tomas;Database=postgres";

                NpgsqlConnection con = new NpgsqlConnection(connstring);
                con.Open();

                string query = "select pizza_size from pizza join product_table using(prod_id) where product_type = '" + comboBox6.Text + "';";


                NpgsqlCommand ncmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader dr = ncmd.ExecuteReader();

                comboBox5.Items.Clear();
                while (dr.Read())
                {
                    comboBox5.Items.Add(dr["pizza_size"]);

                }
                dr.Close();
                dr.Dispose();



                con.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}
