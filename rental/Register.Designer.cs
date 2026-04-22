namespace rental
{
    partial class Register
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
            pnlRegister = new Panel();
            lblRegister = new Label();
            panel1 = new Panel();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            llblLogin = new LinkLabel();
            btnRegister = new Button();
            pnlRegister.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.Lavender;
            pnlRegister.Controls.Add(lblRegister);
            pnlRegister.Location = new Point(-19, -4);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(499, 117);
            pnlRegister.TabIndex = 0;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Lucida Bright", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.MidnightBlue;
            lblRegister.Location = new Point(133, 27);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(206, 62);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            lblRegister.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(llblLogin);
            panel1.Location = new Point(0, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 104);
            panel1.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Lucida Bright", 10F);
            txtEmail.Location = new Point(148, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Lucida Bright", 11F, FontStyle.Bold);
            lblEmail.ForeColor = Color.MidnightBlue;
            lblEmail.Location = new Point(57, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Lucida Bright", 10F);
            txtUsername.Location = new Point(148, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Lucida Bright", 11F, FontStyle.Bold);
            lblUsername.ForeColor = Color.MidnightBlue;
            lblUsername.Location = new Point(42, 203);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 17);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Lucida Bright", 10F);
            txtPassword.Location = new Point(148, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lucida Bright", 11F, FontStyle.Bold);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(42, 253);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 17);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // llblLogin
            // 
            llblLogin.ActiveLinkColor = Color.MidnightBlue;
            llblLogin.AutoSize = true;
            llblLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            llblLogin.ForeColor = Color.MidnightBlue;
            llblLogin.LinkColor = Color.MidnightBlue;
            llblLogin.Location = new Point(124, 31);
            llblLogin.Name = "llblLogin";
            llblLogin.Size = new Size(184, 19);
            llblLogin.TabIndex = 0;
            llblLogin.TabStop = true;
            llblLogin.Text = "Already have an Account?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Lavender;
            btnRegister.Font = new Font("Lucida Bright", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.MidnightBlue;
            btnRegister.Location = new Point(265, 307);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 481);
            Controls.Add(btnRegister);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            Controls.Add(pnlRegister);
            Name = "Register";
            Text = "Register";
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlRegister;
        private Label lblRegister;
        private Panel panel1;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private LinkLabel llblLogin;
        private Button btnRegister;
    }
}