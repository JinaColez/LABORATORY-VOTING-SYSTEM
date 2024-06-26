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
    public partial class LandingPageofVoter : Form
    {
        public LandingPageofVoter()
        {
            InitializeComponent();
        }

        private void createAccLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RENZ PAGKA CLICK MARERECORD SIYA SA DATABASE YUNG USERNAME OR EMAIL THEN NEXT PAGE
            Voting v = new Voting();
            v.Show();

            this.Hide();
        }
    }
}
