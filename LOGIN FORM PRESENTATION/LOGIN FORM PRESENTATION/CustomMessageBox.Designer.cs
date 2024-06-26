namespace LOGIN_FORM_PRESENTATION
    {
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.CustomMessage = new System.Windows.Forms.Label();
            this.movablePanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.okBt = new System.Windows.Forms.Button();
            this.movablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomMessage
            // 
            this.CustomMessage.AutoSize = true;
            this.CustomMessage.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomMessage.ForeColor = System.Drawing.Color.White;
            this.CustomMessage.Location = new System.Drawing.Point(91, 37);
            this.CustomMessage.Name = "CustomMessage";
            this.CustomMessage.Size = new System.Drawing.Size(123, 23);
            this.CustomMessage.TabIndex = 0;
            this.CustomMessage.Text = "CustomMessage";
            this.CustomMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movablePanel
            // 
            this.movablePanel.Controls.Add(this.closeLabel);
            this.movablePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.movablePanel.Location = new System.Drawing.Point(1, 0);
            this.movablePanel.Name = "movablePanel";
            this.movablePanel.Size = new System.Drawing.Size(291, 19);
            this.movablePanel.TabIndex = 16;
            this.movablePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.movablePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoveEvent);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.closeLabel.Location = new System.Drawing.Point(248, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(51, 23);
            this.closeLabel.TabIndex = 17;
            this.closeLabel.Text = "CLOSE";
            this.closeLabel.Click += new System.EventHandler(this.closeEvent);
            // 
            // okBt
            // 
            this.okBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(240)))));
            this.okBt.FlatAppearance.BorderSize = 0;
            this.okBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBt.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBt.ForeColor = System.Drawing.Color.White;
            this.okBt.Location = new System.Drawing.Point(111, 63);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(78, 23);
            this.okBt.TabIndex = 17;
            this.okBt.Text = "OK";
            this.okBt.UseVisualStyleBackColor = false;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(302, 101);
            this.Controls.Add(this.okBt);
            this.Controls.Add(this.CustomMessage);
            this.Controls.Add(this.movablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.movablePanel.ResumeLayout(false);
            this.movablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label CustomMessage;
        private System.Windows.Forms.Panel movablePanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Button okBt;
        }
    }