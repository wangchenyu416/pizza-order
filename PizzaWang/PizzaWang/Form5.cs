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
    public partial class Form5 : Form
    {
        private string connstring;
        public Form5(string cs)
        {
            InitializeComponent();
            connstring = cs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.Text == "add")
            {
                if (comboBox2.Text == "pizza")
                {
                    try
                    {
                        NpgsqlConnection con = new NpgsqlConnection(connstring);
                        //NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=wang;Password=wang;Database=postgres;");
                        con.Open();

                        string query = "select add_pizza( ' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ');";
                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        ncmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" error !");
                    }
                }
                else if (comboBox2.Text == "pasta")
                {
                    try
                    {
                        NpgsqlConnection con = new NpgsqlConnection(connstring);
                        //NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=wang;Password=wang;Database=postgres;");
                        con.Open();

                        string query = "select add_pasta( ' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ');";
                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        ncmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" error !");
                    }
                
                }
                else if (comboBox2.Text == "sauce")
                {
                    try
                    {
                        NpgsqlConnection con = new NpgsqlConnection(connstring);
                        //NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=wang;Password=wang;Database=postgres;");
                        con.Open();

                        string query = "select add_sauce( ' " + textBox1.Text + " ' , ' " + textBox3.Text + " ');";
                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        ncmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" error !");
                    }
                }
                else if (comboBox2.Text == "dessert")
                {
                    
                    try
                    {
                        NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=wang;Password=wang;Database=postgres;");
                        con.Open();

                        string query = "select add_dessert( ' " + textBox1.Text + " ' , ' " + textBox3.Text + " ');";
                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        ncmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" error !");
                    }
                }
                else if (comboBox2.Text == "drink")
                {
                    try
                    {
                        NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=wang;Password=wang;Database=postgres;");
                        con.Open();

                        string query = "select add_drink( ' " + textBox1.Text + " ' , ' " + textBox2.Text + " ' , ' " + textBox3.Text + " ');";
                        NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                        ncmd.ExecuteNonQuery();

                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" error !");
                    }
                }

            }
            else if(comboBox1.Text == "delete")
            {

            }
            else if(comboBox1.Text == "update")
            {

            }

             


             
            
            
            
            if (comboBox2.Text == "pizza")
            {
                label6.Text = comboBox2.Text;
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
            }
            else if (comboBox2.Text == "pasta")
            {
                label6.Text = "";
                label7.Text = comboBox2.Text; ;
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
            }
            else if(comboBox2.Text == "sauce")
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = comboBox2.Text; ;
                label9.Text = "";
                label10.Text = "";
            }
            else if (comboBox2.Text == "dessert")
            {
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = comboBox2.Text; ;
                label10.Text = "";
            }
            else if (comboBox2.Text == "drink")
            {
                label6.Text = 
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = comboBox2.Text; ;
            }

            //--------------------------------------------------
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from pizza;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                //MessageBox.Show("...");
                con.Close();


            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from pasta;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                DataSet ds1 = new DataSet();
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(query, con);
                ds1.Reset();
                da1.Fill(ds1);
                dt1 = ds1.Tables[0];
                dataGridView2.DataSource = dt1;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from sauce;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                DataSet ds2 = new DataSet();
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(query, con);
                ds2.Reset();
                da2.Fill(ds2);
                dt2 = ds2.Tables[0];
                dataGridView3.DataSource = dt2;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from dessert;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt3 = new DataTable();
                DataSet ds3 = new DataSet();
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(query, con);
                ds3.Reset();
                da3.Fill(ds3);
                dt3 = ds3.Tables[0];
                dataGridView4.DataSource = dt3;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from drink;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt4 = new DataTable();
                DataSet ds4 = new DataSet();
                NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(query, con);
                ds4.Reset();
                da4.Fill(ds4);
                dt4 = ds4.Tables[0];
                dataGridView5.DataSource = dt4;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from product_table;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt5 = new DataTable();
                DataSet ds5 = new DataSet();
                NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(query, con);
                ds5.Reset();
                da5.Fill(ds5);
                dt5 = ds5.Tables[0];
                dataGridView6.DataSource = dt5;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from pizza;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                //MessageBox.Show("...");
                con.Close();


            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from pasta;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt1 = new DataTable();
                DataSet ds1 = new DataSet();
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(query, con);
                ds1.Reset();
                da1.Fill(ds1);
                dt1 = ds1.Tables[0];
                dataGridView2.DataSource = dt1;

                //MessageBox.Show("...");
                con.Close();
                
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from sauce;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                DataSet ds2 = new DataSet();
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(query, con);
                ds2.Reset();
                da2.Fill(ds2);
                dt2 = ds2.Tables[0];
                dataGridView3.DataSource = dt2;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from dessert;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt3 = new DataTable();
                DataSet ds3 = new DataSet();
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(query, con);
                ds3.Reset();
                da3.Fill(ds3);
                dt3 = ds3.Tables[0];
                dataGridView4.DataSource = dt3;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from drink;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt4 = new DataTable();
                DataSet ds4 = new DataSet();
                NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(query, con);
                ds4.Reset();
                da4.Fill(ds4);
                dt4 = ds4.Tables[0];
                dataGridView5.DataSource = dt4;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            //--------------------------------------------------------------------------------

            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=0123456789Abc;Database=postgres;");
                con.Open();

                string query = "select * from product_table;";


                // NpgsqlCommand ncmd = new NpgsqlCommand(query, con);
                //ncmd.ExecuteNonQuery();

                DataTable dt5 = new DataTable();
                DataSet ds5 = new DataSet();
                NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(query, con);
                ds5.Reset();
                da5.Fill(ds5);
                dt5 = ds5.Tables[0];
                dataGridView6.DataSource = dt5;

                //MessageBox.Show("...");
                con.Close();

            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }

            label6.Text = "Pizza";
            label7.Text = "Pasta";
            label8.Text = "Sauce";
            label9.Text = "Dessert";
            label10.Text = "Drink";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
            
        }
    }
}
