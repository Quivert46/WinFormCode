namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblLogin = new Label();
            lblPassword = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            btnExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(57, 55);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(107, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Ten dang nhap";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(57, 112);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mat khau";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(184, 55);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(400, 27);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += txtLogin_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(185, 112);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(184, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(401, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Dang Nhap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += txtLogin_TextChanged;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(628, 114);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(67, 24);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(184, 237);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(401, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Button btnExit;
        private ErrorProvider errorProvider1;
    }
}
