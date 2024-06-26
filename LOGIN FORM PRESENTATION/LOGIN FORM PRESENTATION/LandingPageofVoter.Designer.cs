namespace LOGIN_FORM_PRESENTATION
{
    partial class LandingPageofVoter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailRegistration = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.createAccLabel = new System.Windows.Forms.Label();
            this.ruleAgreeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LOGIN_FORM_PRESENTATION.Properties.Resources.loadingScreen;
            this.pictureBox1.Location = new System.Drawing.Point(177, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // emailRegistration
            // 
            this.emailRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.emailRegistration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailRegistration.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegistration.ForeColor = System.Drawing.Color.White;
            this.emailRegistration.Location = new System.Drawing.Point(13, 227);
            this.emailRegistration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailRegistration.Name = "emailRegistration";
            this.emailRegistration.Size = new System.Drawing.Size(470, 32);
            this.emailRegistration.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(174)))));
            this.emailLabel.Location = new System.Drawing.Point(14, 201);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(142, 23);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "EMAIL OR USERNAME";
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.createAccLabel.Location = new System.Drawing.Point(118, 137);
            this.createAccLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new System.Drawing.Size(244, 37);
            this.createAccLabel.TabIndex = 6;
            this.createAccLabel.Text = "Enter Account Details";
            this.createAccLabel.Click += new System.EventHandler(this.createAccLabel_Click);
            // 
            // ruleAgreeLabel
            // 
            this.ruleAgreeLabel.AutoSize = true;
            this.ruleAgreeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ruleAgreeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleAgreeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(177)))), ((int)(((byte)(180)))));
            this.ruleAgreeLabel.Location = new System.Drawing.Point(14, 276);
            this.ruleAgreeLabel.Name = "ruleAgreeLabel";
            this.ruleAgreeLabel.Size = new System.Drawing.Size(235, 19);
            this.ruleAgreeLabel.TabIndex = 15;
            this.ruleAgreeLabel.Text = "Fill out the textbox at the top to continue.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(470, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LandingPageofVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(496, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ruleAgreeLabel);
            this.Controls.Add(this.createAccLabel);
            this.Controls.Add(this.emailRegistration);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LandingPageofVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandingPageofVoter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox emailRegistration;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label createAccLabel;
        private System.Windows.Forms.Label ruleAgreeLabel;
        private System.Windows.Forms.Button button2;
    }
}