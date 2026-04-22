namespace rental
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
            lblLogin = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            llblLogin = new LinkLabel();
            pnlLogin = new Panel();
            panel1 = new Panel();
            pnlLogin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Lucida Bright", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.MidnightBlue;
            lblLogin.Location = new Point(91, 31);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(172, 54);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += lblLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(106, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(136, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MidnightBlue;
            lblUsername.Location = new Point(22, 157);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(22, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(136, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lavender;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.MidnightBlue;
            btnLogin.Location = new Point(125, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // llblLogin
            // 
            llblLogin.ActiveLinkColor = Color.White;
            llblLogin.AutoSize = true;
            llblLogin.BackColor = Color.Transparent;
            llblLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llblLogin.ForeColor = Color.MidnightBlue;
            llblLogin.LinkColor = Color.MidnightBlue;
            llblLogin.Location = new Point(122, 40);
            llblLogin.Name = "llblLogin";
            llblLogin.Size = new Size(141, 19);
            llblLogin.TabIndex = 6;
            llblLogin.TabStop = true;
            llblLogin.Text = "Create an Account?";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.Lavender;
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(-10, -1);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(364, 115);
            pnlLogin.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(llblLogin);
            panel1.Location = new Point(-21, 310);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 157);
            panel1.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(340, 455);
            Controls.Add(panel1);
            Controls.Add(pnlLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Name = "Login";
            Text = "login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel llblLogin;
        private Panel pnlLogin;
        private Panel panel1;
    }
}