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
    public partial class Voting3 : Form
    {
        public Voting3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Voting2 v2 = new Voting2();
            v2.Show();

            this.Hide();
        }

        private void messageBox()
        {
            CustomMessageBox cm = new CustomMessageBox("OKIDOKS");
            cm.Show();

            this.Hide();
        }

        private void VOTE3BTN_Click(object sender, EventArgs e)
        {
            //RENZ PAGKA CLICK NG VOTE LALABAS YUNG MESSAGEBOX NA CONFIRMED LAHAT NG VOTE
            if (voteBox.Text == "RENZ")
            {
                RENZ.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "BARDS")
            {
                BARDS.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "MARK")
            {
                MARK.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "IMOT")
            {
                IMOT.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "VINCE")
            {
                VINCE.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "CHARLIE")
            {
                CHARLIE.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "MJ")
            {
                MJ.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "IAN")
            {
                IAN.BringToFront();
                messageBox();
            }
            else if (voteBox.Text == "JAKE")
            {
                JAKE.BringToFront();
                messageBox();
            }
            else
            {
                CARLO.BringToFront();
                messageBox();
            }
        }

        private void Voting3_Load(object sender, EventArgs e)
        {

        }
    }
}
