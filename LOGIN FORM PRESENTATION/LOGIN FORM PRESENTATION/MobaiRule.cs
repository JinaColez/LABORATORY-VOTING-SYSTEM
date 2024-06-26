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
    public partial class MobaiRule : Form
    {
        public MobaiRule()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            LandingPageofVoter LPV = new LandingPageofVoter();
            LPV.Show();
            this.Hide();
        }

        private void MobaiRule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void MobaiRule_Load(object sender, EventArgs e)
            {
          
            }

        private void continueVoteButt_Click(object sender, EventArgs e)
            {
            LandingPageofVoter LPV = new LandingPageofVoter();
            LPV.Show();

            this.Hide();
            }
        }
}
