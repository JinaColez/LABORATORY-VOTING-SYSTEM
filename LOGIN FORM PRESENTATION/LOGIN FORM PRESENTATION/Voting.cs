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
    public partial class Voting : Form
    {
        public Voting()
        {
            InitializeComponent();
        }

        private void VINCE_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            LandingPageofVoter LPV = new LandingPageofVoter();
            LPV.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void votingpage2()
        {
           Voting2 secondVotingPage = new Voting2();
            secondVotingPage.Show();
            this.Hide();
        }

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            //RENZ PAGKA CLICK NG VOTE MAPUPUNTA SA NEXT PAGE
            if (voteBox.Text == "RENZ")
            {
                RENZ.BringToFront();
                

                
            }
            else if (voteBox.Text == "BARDS")
            {
                BARDS.BringToFront();
               
            }
            else if (voteBox.Text == "MARK")
            {
                MARK.BringToFront();
            }
            else if (voteBox.Text == "IMOT")
            {
                IMOT.BringToFront();
            }
            else if (voteBox.Text == "VINCE")
            {
                VINCE.BringToFront();
                
            }
            else if (voteBox.Text == "CHARLIE")
            {
                CHARLIE.BringToFront();
             
            }
            else if (voteBox.Text == "MJ")
            {
                MJ.BringToFront();
               
            }
            else if (voteBox.Text == "IAN")
            {
                IAN.BringToFront();
             
            }
            else if (voteBox.Text == "JAKE")
            {
                JAKE.BringToFront();
              
            }
            else
            {
                CARLO.BringToFront();
           
            }
        }

        private void Voting_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IAN_Click(object sender, EventArgs e)
        {

        }

        private void MARK_Click(object sender, EventArgs e)
        {

        }

        private void JAKE_Click(object sender, EventArgs e)
        {

        }

        private void IMOT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            votingpage2();
        }
    }
}
