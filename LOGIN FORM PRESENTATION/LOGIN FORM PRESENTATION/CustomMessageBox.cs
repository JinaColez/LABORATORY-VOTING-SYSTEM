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
    public partial class CustomMessageBox : Form
        {
        private string message;
        public Point mouseLoc;
        public CustomMessageBox(string message)
            {
            this.message=message;
            InitializeComponent();
            CustomMessage.Text=message;
            }

        private void CustomMessageBox_Load(object sender, EventArgs e)
            {

            }

        private void mouseDownEvent(object sender, MouseEventArgs e)
            {
            mouseLoc = new Point(-e.X,-e.Y);
            }

        private void mouseMoveEvent(object sender, MouseEventArgs e)
            {
            if (e.Button == MouseButtons.Left)
                {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLoc.X,mouseLoc.Y);
                Location = mousePose;
                }
            }

        private void closeEvent(object sender, EventArgs e)
            {
            this.Close();
            }

        private void okBt_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
