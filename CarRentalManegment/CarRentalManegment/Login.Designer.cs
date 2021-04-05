
namespace CarRentalManegment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxCar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxUserName = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Minimize);
            this.panel1.Controls.Add(this.lbl_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 25);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "LOGIN";
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.AutoSize = true;
            this.lbl_Minimize.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minimize.Location = new System.Drawing.Point(650, 3);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(24, 18);
            this.lbl_Minimize.TabIndex = 1;
            this.lbl_Minimize.Text = "__";
            this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Minimize_Click);
            this.lbl_Minimize.MouseLeave += new System.EventHandler(this.lbl_Minimize_MouseLeave);
            this.lbl_Minimize.MouseHover += new System.EventHandler(this.lbl_Minimize_MouseHover);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.Location = new System.Drawing.Point(676, 3);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(18, 18);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            this.lbl_Exit.MouseLeave += new System.EventHandler(this.lbl_Exit_MouseLeave);
            this.lbl_Exit.MouseHover += new System.EventHandler(this.lbl_Exit_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PictureBoxCar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 335);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "The Better Quality";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(39, 262);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(145, 21);
            this.lbl_Title.TabIndex = 16;
            this.lbl_Title.Text = "The Better Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Car Rental Center";
            // 
            // PictureBoxCar
            // 
            this.PictureBoxCar.BackColor = System.Drawing.Color.Maroon;
            this.PictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxCar.Image")));
            this.PictureBoxCar.Location = new System.Drawing.Point(10, 50);
            this.PictureBoxCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxCar.Name = "PictureBoxCar";
            this.PictureBoxCar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxCar.ShadowDecoration.Parent = this.PictureBoxCar;
            this.PictureBoxCar.Size = new System.Drawing.Size(264, 238);
            this.PictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxCar.TabIndex = 1;
            this.PictureBoxCar.TabStop = false;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.White;
            this.UserPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserPanel.Location = new System.Drawing.Point(358, 167);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(270, 2);
            this.UserPanel.TabIndex = 13;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.Color.White;
            this.PasswordPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordPanel.Location = new System.Drawing.Point(357, 234);
            this.PasswordPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(271, 2);
            this.PasswordPanel.TabIndex = 12;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.AcceptsTab = true;
            this.Passwordtxt.BackColor = System.Drawing.Color.Firebrick;
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.ForeColor = System.Drawing.Color.White;
            this.Passwordtxt.HideSelection = false;
            this.Passwordtxt.Location = new System.Drawing.Point(389, 211);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(238, 16);
            this.Passwordtxt.TabIndex = 11;
            this.Passwordtxt.TabStop = false;
            this.Passwordtxt.Text = "Password";
            this.Passwordtxt.Click += new System.EventHandler(this.Passwordtxt_Click);
            // 
            // UserNametxt
            // 
            this.UserNametxt.AcceptsTab = true;
            this.UserNametxt.BackColor = System.Drawing.Color.Firebrick;
            this.UserNametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNametxt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametxt.ForeColor = System.Drawing.Color.White;
            this.UserNametxt.HideSelection = false;
            this.UserNametxt.Location = new System.Drawing.Point(389, 149);
            this.UserNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(238, 16);
            this.UserNametxt.TabIndex = 10;
            this.UserNametxt.TabStop = false;
            this.UserNametxt.Text = "UserName";
            this.UserNametxt.Click += new System.EventHandler(this.UserNametxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(459, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "LOG IN";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(427, 274);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Green;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(158, 36);
            this.guna2Button1.TabIndex = 19;
            this.guna2Button1.Text = "Log In";
            this.guna2Button1.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(480, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Clear";
            this.label5.Click += new System.EventHandler(this.lbl_Clear_Click);
            // 
            // pictureBoxUserName
            // 
            this.pictureBoxUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxUserName.Image = global::CarRentalManegment.Properties.Resources.usericon;
            this.pictureBoxUserName.Location = new System.Drawing.Point(358, 141);
            this.pictureBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserName.Name = "pictureBoxUserName";
            this.pictureBoxUserName.Size = new System.Drawing.Size(26, 24);
            this.pictureBoxUserName.TabIndex = 8;
            this.pictureBoxUserName.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxPassword.Image = global::CarRentalManegment.Properties.Resources.passwordicon;
            this.pictureBoxPassword.Location = new System.Drawing.Point(356, 206);
            this.pictureBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxPassword.TabIndex = 9;
            this.pictureBoxPassword.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.UserNametxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxUserName);
            this.Controls.Add(this.pictureBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox UserNametxt;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
    }
}