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
    public partial class Form2 : Form
    {
        public Form2()
        {
            Form1 main = this.Owner as Form1;
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.stst == "admin") {
                dataGridView1.Visible = true;
                button1.Visible = true;
               // button2.Visible = true;
                button5.Visible = true;
                textBox1.Visible = true;
                label1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                
                radioButton4.Visible = true;
                radioButton5.Visible = true;



            }
            

            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.logpar". При необходимости она может быть перемещена или удалена.
            this.logparTableAdapter1.Fill(this.database1DataSet2.logpar);


            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "select Logg, rol From logpar order by rol";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();
            dataGridView1.DataSource = dt;

            DateTime localDate = DateTime.Now;

            
           
            if (main.stst == "night" && localDate.Hour > 12)
            {
              
             
                MessageBox.Show("Зайдите в первой половину суток");
                Application.Exit();
            }
            if (main.stst == "day" && localDate.Hour < 12)
            {
                
           
                MessageBox.Show("Зайдите во второй половине суток");
                Application.Exit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                textBox1.Text = "";
                MessageBox.Show("АСТАНАВИТЕСЬ");
            }
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            SqlCommand cmd2 = new SqlCommand("");
                SqlCommand cmd = new SqlCommand("delete from logpar where logg = '" + textBox1.Text + "' ");
                _con.Open();
                cmd.Connection = _con;
                cmd.ExecuteNonQuery();
                _con.Close();
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "select Logg, rol From logpar where rol='jdun'";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();
            dataGridView1.DataSource = dt;
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string rang = "";
            if (radioButton1.Checked == true)
            {
                rang = "user";

            };
            if (radioButton2.Checked == true)
            {
                
                rang = "night";
            };
            
            if (radioButton4.Checked == true)
            {
                rang = "day";
            };
            if (radioButton5.Checked == true)
            {
                rang = "jdun";
            };

            SqlCommand cmd = new SqlCommand("update logpar set rol = '"+rang+"',tries=0 where logg = '"+textBox1.Text+"'");
            _con.Open();
            cmd.Connection = _con;
            cmd.ExecuteNonQuery();
            _con.Close();
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "select Logg, rol From logpar order by rol";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "Update logpar set tries = 0 where Logg = '"+textBox1.Text+"'";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();
        }

       
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logparTableAdapter.FillBy(this.database1DataSet1.logpar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.logparTableAdapter1.FillBy(this.database1DataSet2.logpar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.logparTableAdapter1.FillBy1(this.database1DataSet2.logpar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "select Logg, rol From logpar order by rol";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();
            dataGridView1.DataSource = dt;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Шифр\Админестратор\администрирование\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True";
            SqlConnection _con = new SqlConnection(con);
            string querly = "Update logpar set tries = 0 where Logg = '" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(querly, _con);
            DataTable dt = new DataTable("Loggin");
            SqlDataAdapter _add = new SqlDataAdapter(command);
            _con.Open();
            _add.Fill(dt);
            _con.Close();

        }
    }
}
