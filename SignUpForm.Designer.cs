namespace Linki.Client
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.appNameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.nicknameInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.firstPasswordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.secondPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.previousFormButton = new System.Windows.Forms.Button();
            this.signUpStatusLabel = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appNameLabel
            // 
            this.appNameLabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appNameLabel.Location = new System.Drawing.Point(287, 9);
            this.appNameLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(316, 91);
            this.appNameLabel.TabIndex = 11;
            this.appNameLabel.Text = "Linki";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(169, 156);
            this.loginLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(93, 36);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Логин";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginInput
            // 
            this.loginInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginInput.Location = new System.Drawing.Point(297, 156);
            this.loginInput.Name = "loginInput";
            this.loginInput.Size = new System.Drawing.Size(304, 36);
            this.loginInput.TabIndex = 10;
            // 
            // signUpLabel
            // 
            this.signUpLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.Location = new System.Drawing.Point(283, 86);
            this.signUpLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(316, 47);
            this.signUpLabel.TabIndex = 17;
            this.signUpLabel.Text = "Регистрация";
            this.signUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.Location = new System.Drawing.Point(297, 451);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(304, 36);
            this.signUpButton.TabIndex = 16;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nicknameLabel.Location = new System.Drawing.Point(148, 210);
            this.nicknameLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(131, 36);
            this.nicknameLabel.TabIndex = 19;
            this.nicknameLabel.Text = "Никнейм";
            this.nicknameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nicknameInput
            // 
            this.nicknameInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nicknameInput.Location = new System.Drawing.Point(297, 210);
            this.nicknameInput.Name = "nicknameInput";
            this.nicknameInput.Size = new System.Drawing.Size(304, 36);
            this.nicknameInput.TabIndex = 18;
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(148, 262);
            this.emailLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(131, 36);
            this.emailLabel.TabIndex = 21;
            this.emailLabel.Text = "E-Mail";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(297, 262);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(304, 36);
            this.emailInput.TabIndex = 20;
            // 
            // firstPasswordLabel
            // 
            this.firstPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstPasswordLabel.Location = new System.Drawing.Point(148, 314);
            this.firstPasswordLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.firstPasswordLabel.Name = "firstPasswordLabel";
            this.firstPasswordLabel.Size = new System.Drawing.Size(131, 36);
            this.firstPasswordLabel.TabIndex = 23;
            this.firstPasswordLabel.Text = "Пароль";
            this.firstPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(297, 314);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(304, 36);
            this.passwordInput.TabIndex = 22;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // secondPasswordLabel
            // 
            this.secondPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondPasswordLabel.Location = new System.Drawing.Point(148, 366);
            this.secondPasswordLabel.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.secondPasswordLabel.Name = "secondPasswordLabel";
            this.secondPasswordLabel.Size = new System.Drawing.Size(143, 59);
            this.secondPasswordLabel.TabIndex = 25;
            this.secondPasswordLabel.Text = "Повторить пароль";
            this.secondPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordInput.Location = new System.Drawing.Point(297, 379);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.Size = new System.Drawing.Size(304, 36);
            this.confirmPasswordInput.TabIndex = 24;
            this.confirmPasswordInput.UseSystemPasswordChar = true;
            // 
            // previousFormButton
            // 
            this.previousFormButton.BackColor = System.Drawing.SystemColors.Menu;
            this.previousFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousFormButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.previousFormButton.Image = ((System.Drawing.Image)(resources.GetObject("previousFormButton.Image")));
            this.previousFormButton.Location = new System.Drawing.Point(21, 26);
            this.previousFormButton.Name = "previousFormButton";
            this.previousFormButton.Size = new System.Drawing.Size(65, 61);
            this.previousFormButton.TabIndex = 27;
            this.previousFormButton.UseVisualStyleBackColor = false;
            this.previousFormButton.Click += new System.EventHandler(this.previousFormButton_Click);
            // 
            // signUpStatusLabel
            // 
            this.signUpStatusLabel.AutoSize = true;
            this.signUpStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpStatusLabel.Location = new System.Drawing.Point(161, 498);
            this.signUpStatusLabel.Name = "signUpStatusLabel";
            this.signUpStatusLabel.Size = new System.Drawing.Size(0, 23);
            this.signUpStatusLabel.TabIndex = 29;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectionStatusLabel.Location = new System.Drawing.Point(12, 630);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(0, 22);
            this.connectionStatusLabel.TabIndex = 31;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.signUpStatusLabel);
            this.Controls.Add(this.previousFormButton);
            this.Controls.Add(this.secondPasswordLabel);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.firstPasswordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nicknameInput);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginInput);
            this.Controls.Add(this.appNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUpForm";
            this.Text = "1";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label appNameLabel;
        private Label loginLabel;
        private TextBox loginInput;
        private Label signUpLabel;
        private Button signUpButton;
        private Label nicknameLabel;
        private TextBox nicknameInput;
        private Label emailLabel;
        private TextBox emailInput;
        private Label firstPasswordLabel;
        private TextBox passwordInput;
        private Label secondPasswordLabel;
        private TextBox confirmPasswordInput;
        private Button previousFormButton;
        private Label signUpStatusLabel;
        private Label connectionStatusLabel;
    }
}