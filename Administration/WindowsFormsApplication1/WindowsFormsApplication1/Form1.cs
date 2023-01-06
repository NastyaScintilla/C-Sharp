using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        public string stst;
       

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            this.Hide();
            form3.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string zap = "SELECT * From logpar";
            SqlCommand _zap = new SqlCommand(zap, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(_zap);
            _con.Open();
            _add.Fill(dt);
            _con.Close();

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (textBox1.Text == dt.Rows[i][0].ToString())
                    {
                        if (textBox2.Text == dt.Rows[i][1].ToString())
                        {
                            if (dt.Rows[i][2].ToString() != "jdun")
                            {
                                stst = dt.Rows[i][2].ToString();
                                Form2 form2 = new Form2();
                                form2.Owner = this;
                                this.Hide();
                                form2.Show();


                            }
                            else { MessageBox.Show("Ожидайте активации аккаунта(Возможно вы заблокированы)"); }


                        }
                        else

                        {
                            MessageBox.Show("Неверный логин или пароль.");
                            string trrrr = "Update logpar set tries = tries + 1 where Logg = '" + textBox1.Text + "'";
                            SqlCommand trise = new SqlCommand(trrrr, _con);
                            _con.Open();
                            trise.ExecuteNonQuery();
                            _con.Close();
                            string unizhenie = "Update logpar set rol = 'jdun' where tries > 3";
                            SqlCommand _unizhenie = new SqlCommand(unizhenie, _con);
                            _con.Open();
                            _unizhenie.ExecuteNonQuery();
                            _con.Close();

                        }
                    }


                }


            }
            else { MessageBox.Show("Введите логин и пароль."); }
        }


    }
}





