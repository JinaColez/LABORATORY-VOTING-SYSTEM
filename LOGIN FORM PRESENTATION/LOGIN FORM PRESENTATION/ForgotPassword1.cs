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
    public partial class ForgotPassword1 : Form
    {
        public ForgotPassword1()
        {
            InitializeComponent();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void escapeButt_Click(object sender, EventArgs e)
            {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
            }

        private void changepasswordButt_Click(object sender, EventArgs e)
            {
            try
                {
                string conn = " datasource=localhost;database=login;port=3306;username=root;password =; ";
                string query = "update login set password = '"+newpasswordBox.Text+"' where login.email = '"+emailBox.Text+"'";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                    {
                    /*MessageBox.Show("New password implement");*/
                    }
                else
                    {
                    CustomMessageBox customMessage = new CustomMessageBox("Password Changed");
                    customMessage.ShowDialog();
                    Login_Form login = new Login_Form();
                    login.Show();
                    this.Hide();
                    }
                 
                connection.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            }

        private void hidePassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '*')
                {
                showPassBt.BringToFront();
                newpasswordBox.PasswordChar = '\0';
                }
            }

        private void showPassBt_Click(object sender, EventArgs e)
            {
            if (newpasswordBox.PasswordChar == '\0')
                {
                hidePassBt.BringToFront();
                newpasswordBox.PasswordChar = '*';
                }
            }
        }
}
