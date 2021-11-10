
namespace NZHorsRacing
{
    partial class LoginForm
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
            this.namelabel = new System.Windows.Forms.Label();
            this.titllabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AddJockeyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.namelabel.Location = new System.Drawing.Point(53, 44);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(220, 42);
            this.namelabel.TabIndex = 9;
            this.namelabel.Text = "NZ Horse Racing";
            // 
            // titllabel
            // 
            this.titllabel.AutoSize = true;
            this.titllabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titllabel.Location = new System.Drawing.Point(70, 121);
            this.titllabel.Name = "titllabel";
            this.titllabel.Size = new System.Drawing.Size(530, 48);
            this.titllabel.TabIndex = 10;
            this.titllabel.Text = "Management System";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(288, 252);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.UserNameTextBox.TabIndex = 13;
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(183, 256);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(101, 18);
            this.UserNameLabel.TabIndex = 15;
            this.UserNameLabel.Text = "User Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(192, 314);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(90, 18);
            this.PasswordLabel.TabIndex = 16;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(288, 310);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(165, 26);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AddJockeyButton
            // 
            this.AddJockeyButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddJockeyButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJockeyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddJockeyButton.Location = new System.Drawing.Point(123, 402);
            this.AddJockeyButton.Name = "AddJockeyButton";
            this.AddJockeyButton.Size = new System.Drawing.Size(150, 50);
            this.AddJockeyButton.TabIndex = 19;
            this.AddJockeyButton.Text = "Login";
            this.AddJockeyButton.UseVisualStyleBackColor = false;
            this.AddJockeyButton.Click += new System.EventHandler(this.AddJockeyButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(379, 402);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 50);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddJockeyButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.titllabel);
            this.Controls.Add(this.namelabel);
            this.Name = "LoginForm";
            this.Text = "NZHorseRacing Management System";
            this.Click += new System.EventHandler(this.ExitButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label titllabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button AddJockeyButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

