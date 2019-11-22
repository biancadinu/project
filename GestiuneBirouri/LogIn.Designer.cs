namespace GestiuneBirouri
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.labelTextWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(340, 179);
            this.usernameTextBox.MaximumSize = new System.Drawing.Size(200, 50);
            this.usernameTextBox.MinimumSize = new System.Drawing.Size(200, 50);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 49);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.Text = "ceva";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(340, 245);
            this.passwordTextBox.MaximumSize = new System.Drawing.Size(200, 50);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(200, 50);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 49);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "123456";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.LightGreen;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logInButton.Location = new System.Drawing.Point(340, 315);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(200, 38);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.LightGreen;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(340, 359);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 38);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseMnemonic = false;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // labelTextWelcome
            // 
            this.labelTextWelcome.AutoSize = true;
            this.labelTextWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelTextWelcome.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelTextWelcome.Location = new System.Drawing.Point(324, 124);
            this.labelTextWelcome.Name = "labelTextWelcome";
            this.labelTextWelcome.Size = new System.Drawing.Size(227, 25);
            this.labelTextWelcome.TabIndex = 4;
            this.labelTextWelcome.Text = "Welcome, please LogIn";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelTextWelcome);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "GBApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label labelTextWelcome;
    }
}

