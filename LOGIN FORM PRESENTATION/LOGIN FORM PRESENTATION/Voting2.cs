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
    public partial class Voting2 : Form
    {
        public Voting2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Voting v = new Voting();
            v.Show();

            this.Hide();
        }

        private void thirdvotingform()
        {
            Voting3 voting3 = new Voting3();
            voting3.Show();
            this.Hide();
        }

        private void VOTE2BTN_Click(object sender, EventArgs e)
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
;
            }
        }

        private void Voting2_Load(object sender, EventArgs e)
        {

        }
    }
}
