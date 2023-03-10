namespace Linki.Client
{
    partial class AuthenticationForm
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
            this.loginInput = new System.Windows.Forms.TextBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.connectToServerLabel = new System.Windows.Forms.Label();
            this.connectToServerStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginInput
            // 
            this.loginInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginInput.Location = new System.Drawing.Point(71, 206);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(304, 36);
            this.loginInput.TabIndex = 1;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appNameLabel.Location = new System.Drawing.Point(59, 58);
            this.appNameLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(316, 91);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "Linki";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(149, 159);
            this.loginLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(140, 44);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(149, 245);
            this.passwordLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(140, 44);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Пароль";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(71, 292);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(304, 36);
            this.passwordInput.TabIndex = 5;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.Location = new System.Drawing.Point(71, 348);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(304, 36);
            this.signInButton.TabIndex = 8;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.Location = new System.Drawing.Point(71, 403);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(304, 36);
            this.signUpButton.TabIndex = 9;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // connectToServerLabel
            // 
            this.connectToServerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.connectToServerLabel.AutoSize = true;
            this.connectToServerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectToServerLabel.Location = new System.Drawing.Point(59, 573);
            this.connectToServerLabel.Name = "connectToServerLabel";
            this.connectToServerLabel.Size = new System.Drawing.Size(330, 23);
            this.connectToServerLabel.TabIndex = 11;
            this.connectToServerLabel.Text = "Статус подключения к серверу:";
            this.connectToServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectToServerStatusLabel
            // 
            this.connectToServerStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.connectToServerStatusLabel.AutoSize = true;
            this.connectToServerStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectToServerStatusLabel.Location = new System.Drawing.Point(28, 614);
            this.connectToServerStatusLabel.Name = "connectToServerStatusLabel";
            this.connectToServerStatusLabel.Size = new System.Drawing.Size(0, 23);
            this.connectToServerStatusLabel.TabIndex = 12;
            this.connectToServerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(438, 675);
            this.Controls.Add(this.connectToServerStatusLabel);
            this.Controls.Add(this.connectToServerLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthenticationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthenticationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            this.Shown += new System.EventHandler(this.AuthenticationForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginInput;
        private Label appNameLabel;
        private Label loginLabel;
        private Label passwordLabel;
        private TextBox passwordInput;
        private Button signInButton;
        private Button signUpButton;


        //--MY_CODE---
        private Control testControl = new Control();
        private Label connectToServerLabel;
        private Label connectToServerStatusLabel;
    }
}