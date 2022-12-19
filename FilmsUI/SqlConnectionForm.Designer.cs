namespace FilmsUI
{
    partial class SqlConnectionForm
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
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.Location = new System.Drawing.Point(8, 8);
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.PlaceholderText = "Имя сервера";
            this.ConnectionTextBox.Size = new System.Drawing.Size(288, 27);
            this.ConnectionTextBox.TabIndex = 0;
            // 
            // ConnectionEnter
            // 
            this.ConnectionEnter.Location = new System.Drawing.Point(8, 71);
            this.ConnectionEnter.Name = "ConnectionEnter";
            this.ConnectionEnter.Size = new System.Drawing.Size(94, 29);
            this.ConnectionEnter.TabIndex = 1;
            this.ConnectionEnter.Text = "Войти";
            this.ConnectionEnter.UseVisualStyleBackColor = true;
            this.ConnectionEnter.Click += new System.EventHandler(this.ConnectionEnter_Click);
            // 
            // SqlConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 112);
            this.Controls.Add(this.ConnectionEnter);
            this.Controls.Add(this.ConnectionTextBox);
            this.Name = "SqlConnectionForm";
            this.Text = "Подключение к базе ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ConnectionTextBox;
        private Button ConnectionEnter;
    }
}