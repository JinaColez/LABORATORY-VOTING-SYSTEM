using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void Admin_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

 
        

        private void createbt_Click(object sender, EventArgs e)
        {
            Create c = new Create();
            c.Show();

            this.Hide();
        }

        private void readbt_Click(object sender, EventArgs e)
        {
           groupBox3.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
        }

        private void gridview()
        {
            string conn ="datasource=localhost;database=login;port=3306;SSLMode=none;username=root;password=;";
            MySqlConnection con = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand("select * from login", con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(); sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                /*bSource.DataSource = dbdataset; dataGridView1.DataSource = bSource; sda.Update(dbdataset);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 
        private void dashboard_Load(object sender, EventArgs e)
        {
            gridview();
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            Update p = new Update();
            p.Show();

            this.Hide();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {
            Delete dl = new Delete();
            dl.Show();

            this.Hide();
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
