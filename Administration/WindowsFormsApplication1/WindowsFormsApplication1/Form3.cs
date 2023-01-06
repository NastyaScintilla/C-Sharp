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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string zap = "insert into logpar (Logg,pass,rol,tries) values ('" + textBox1.Text + "','" + textBox2.Text + "','jdun',0) ";
            SqlCommand skkka = new SqlCommand(zap, _con);
            string quer = "select*From logpar";
            SqlCommand comma = new SqlCommand(quer, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(comma);
            _con.Open();
            _add.Fill(dt);



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == textBox1.Text)
                {
                    MessageBox.Show("Логин занят, введите другой");
                    textBox1.Text = "";
                }
            }
            if (textBox1.Text != "")
            {
                skkka.ExecuteNonQuery();
                _con.Close();
                MessageBox.Show("Вы подали заявку на регестрацию");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

           
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
