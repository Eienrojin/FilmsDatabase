namespace FilmsUI
{
    partial class Registration
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegistrationLoginTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationPasswordAgainTextBox = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.RegistrationBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(12, 181);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(201, 29);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationLoginTextBox
            // 
            this.RegistrationLoginTextBox.Location = new System.Drawing.Point(12, 12);
            this.RegistrationLoginTextBox.Name = "RegistrationLoginTextBox";
            this.RegistrationLoginTextBox.PlaceholderText = "Логин";
            this.RegistrationLoginTextBox.Size = new System.Drawing.Size(201, 27);
            this.RegistrationLoginTextBox.TabIndex = 1;
            // 
            // RegistrationPasswordTextBox
            // 
            this.RegistrationPasswordTextBox.Location = new System.Drawing.Point(12, 45);
            this.RegistrationPasswordTextBox.Name = "RegistrationPasswordTextBox";
            this.RegistrationPasswordTextBox.PasswordChar = '*';
            this.RegistrationPasswordTextBox.PlaceholderText = "Пароль";
            this.RegistrationPasswordTextBox.Size = new System.Drawing.Size(201, 27);
            this.RegistrationPasswordTextBox.TabIndex = 2;
            // 
            // RegistrationPasswordAgainTextBox
            // 
            this.RegistrationPasswordAgainTextBox.Location = new System.Drawing.Point(12, 78);
            this.RegistrationPasswordAgainTextBox.Name = "RegistrationPasswordAgainTextBox";
            this.RegistrationPasswordAgainTextBox.PasswordChar = '*';
            this.RegistrationPasswordAgainTextBox.PlaceholderText = "Повторите пароль";
            this.RegistrationPasswordAgainTextBox.Size = new System.Drawing.Size(201, 27);
            this.RegistrationPasswordAgainTextBox.TabIndex = 3;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(219, 47);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(150, 24);
            this.ShowPasswordCheckBox.TabIndex = 5;
            this.ShowPasswordCheckBox.Text = "Показать пароль";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // RegistrationBackButton
            // 
            this.RegistrationBackButton.Location = new System.Drawing.Point(219, 181);
            this.RegistrationBackButton.Name = "RegistrationBackButton";
            this.RegistrationBackButton.Size = new System.Drawing.Size(130, 29);
            this.RegistrationBackButton.TabIndex = 7;
            this.RegistrationBackButton.Text = "Назад";
            this.RegistrationBackButton.UseVisualStyleBackColor = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 226);
            this.Controls.Add(this.RegistrationBackButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.RegistrationPasswordAgainTextBox);
            this.Controls.Add(this.RegistrationPasswordTextBox);
            this.Controls.Add(this.RegistrationLoginTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RegisterButton;
        private TextBox RegistrationLoginTextBox;
        private TextBox RegistrationPasswordTextBox;
        private TextBox RegistrationPasswordAgainTextBox;
        private CheckBox ShowPasswordCheckBox;
        private Button RegistrationBackButton;
    }
}