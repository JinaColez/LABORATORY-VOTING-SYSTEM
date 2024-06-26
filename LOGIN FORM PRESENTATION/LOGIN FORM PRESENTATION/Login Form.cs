using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Login_Form : Form
    {
        public Point mouseLoc;
        public Login_Form()
        {
            InitializeComponent();
             
              
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
        private void mouseDownEvent(object sender, MouseEventArgs e)
            {
            mouseLoc = new Point(-e.X, -e.Y);
            }

        private void mouseMoveEvent(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);
                Location = mousePose;

                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            //RENZ PAG NALOGIN YUNG ACC NG ADMIN MAPUPUNTA SA SERVER PAGE
            try
            {
                string conn = " datasource=localhost;database=login;port=3306;username=root;password =; ";
                string query = "select * from login where (username || email) = '" + usernameEmailBox.Text + "' && password = '" + passwordBox.Text + "'  ";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    
                    CustomMessageBox customMessage = new CustomMessageBox("Login Successful");
                    customMessage.ShowDialog();
                    MobaiRule calc = new MobaiRule();
                    calc.Show();
                    this.Hide();
                     
                    
                }
                else if (usernameEmailBox.Text == "admin" && passwordBox.Text == "admin123")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password are incorrect");
                    passwordBox.Clear();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Register_Click(object sender, EventArgs e)
            {
                RegistrationForm registration = new RegistrationForm();
                registration.Show();
                this.Hide();
            }
       

        private void forgotLabel_Click(object sender, EventArgs e)
        {
            ForgotPassword1 fp = new ForgotPassword1();
            fp.Show();
            this.Hide();
        }

        private void hidePassBt_Click(object sender, EventArgs e)
            {
            if (passwordBox.PasswordChar == '*')
                {
                showPassBt.BringToFront();
                passwordBox.PasswordChar = '\0';
                }
           }

        private void showPassBt_Click(object sender, EventArgs e)
            {
            if (passwordBox.PasswordChar == '\0')
                {
                hidePassBt.BringToFront();
                passwordBox.PasswordChar = '*';
                }
             }

       

        }
}
