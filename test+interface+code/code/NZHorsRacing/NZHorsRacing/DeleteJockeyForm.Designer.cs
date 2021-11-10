
namespace NZHorsRacing
{
    partial class DeleteJockeyForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DeleteJockeyButton = new System.Windows.Forms.Button();
            this.JockeyIDLabel = new System.Windows.Forms.Label();
            this.nZHorseRacingDataSet = new NZHorsRacing.NZHorseRacingDataSet();
            this.jOCKEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOCKEYTableAdapter = new NZHorsRacing.NZHorseRacingDataSetTableAdapters.JOCKEYTableAdapter();
            this.JockeyDataGridView = new System.Windows.Forms.DataGridView();
            this.jockeyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JockeyIDtextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOCKEYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JockeyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chose one Jockey that you want to delete:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(128, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(410, 48);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Delete Jockey";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(308, 357);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(114, 18);
            this.DateOfBirthLabel.TabIndex = 20;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(356, 313);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(66, 18);
            this.WeightLabel.TabIndex = 19;
            this.WeightLabel.Text = "Weight:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(323, 269);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(99, 18);
            this.FirstNameLabel.TabIndex = 17;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(325, 225);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(97, 18);
            this.LastNameLabel.TabIndex = 16;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnButton.Location = new System.Drawing.Point(395, 466);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(182, 50);
            this.ReturnButton.TabIndex = 15;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DeleteJockeyButton
            // 
            this.DeleteJockeyButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteJockeyButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteJockeyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteJockeyButton.Location = new System.Drawing.Point(111, 466);
            this.DeleteJockeyButton.Name = "DeleteJockeyButton";
            this.DeleteJockeyButton.Size = new System.Drawing.Size(182, 50);
            this.DeleteJockeyButton.TabIndex = 14;
            this.DeleteJockeyButton.Text = "Delete Jockey";
            this.DeleteJockeyButton.UseVisualStyleBackColor = false;
            this.DeleteJockeyButton.Click += new System.EventHandler(this.DeleteJockeyButton_Click);
            // 
            // JockeyIDLabel
            // 
            this.JockeyIDLabel.AutoSize = true;
            this.JockeyIDLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JockeyIDLabel.Location = new System.Drawing.Point(329, 181);
            this.JockeyIDLabel.Name = "JockeyIDLabel";
            this.JockeyIDLabel.Size = new System.Drawing.Size(93, 18);
            this.JockeyIDLabel.TabIndex = 28;
            this.JockeyIDLabel.Text = "Jockey ID:";
            // 
            // nZHorseRacingDataSet
            // 
            this.nZHorseRacingDataSet.DataSetName = "NZHorseRacingDataSet";
            this.nZHorseRacingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOCKEYBindingSource
            // 
            this.jOCKEYBindingSource.DataMember = "JOCKEY";
            this.jOCKEYBindingSource.DataSource = this.nZHorseRacingDataSet;
            // 
            // jOCKEYTableAdapter
            // 
            this.jOCKEYTableAdapter.ClearBeforeFill = true;
            // 
            // JockeyDataGridView
            // 
            this.JockeyDataGridView.AllowUserToAddRows = false;
            this.JockeyDataGridView.AllowUserToDeleteRows = false;
            this.JockeyDataGridView.AutoGenerateColumns = false;
            this.JockeyDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.JockeyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JockeyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jockeyIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn});
            this.JockeyDataGridView.DataSource = this.jOCKEYBindingSource;
            this.JockeyDataGridView.Location = new System.Drawing.Point(12, 151);
            this.JockeyDataGridView.Name = "JockeyDataGridView";
            this.JockeyDataGridView.ReadOnly = true;
            this.JockeyDataGridView.Size = new System.Drawing.Size(281, 254);
            this.JockeyDataGridView.TabIndex = 29;
            // 
            // jockeyIDDataGridViewTextBoxColumn
            // 
            this.jockeyIDDataGridViewTextBoxColumn.DataPropertyName = "JockeyID";
            this.jockeyIDDataGridViewTextBoxColumn.HeaderText = "JockeyID";
            this.jockeyIDDataGridViewTextBoxColumn.Name = "jockeyIDDataGridViewTextBoxColumn";
            this.jockeyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jockeyIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // JockeyIDtextBox
            // 
            this.JockeyIDtextBox.Enabled = false;
            this.JockeyIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JockeyIDtextBox.Location = new System.Drawing.Point(428, 173);
            this.JockeyIDtextBox.Multiline = true;
            this.JockeyIDtextBox.Name = "JockeyIDtextBox";
            this.JockeyIDtextBox.Size = new System.Drawing.Size(63, 30);
            this.JockeyIDtextBox.TabIndex = 30;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(428, 219);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(191, 30);
            this.LastNameTextBox.TabIndex = 31;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Enabled = false;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(428, 263);
            this.FirstNameTextBox.Multiline = true;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(191, 30);
            this.FirstNameTextBox.TabIndex = 32;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Enabled = false;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(428, 309);
            this.WeightTextBox.Multiline = true;
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(86, 30);
            this.WeightTextBox.TabIndex = 34;
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Enabled = false;
            this.DateOfBirthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(428, 350);
            this.DateOfBirthTextBox.Multiline = true;
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(100, 30);
            this.DateOfBirthTextBox.TabIndex = 35;
            // 
            // DeleteJockeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.DateOfBirthTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.JockeyIDtextBox);
            this.Controls.Add(this.JockeyDataGridView);
            this.Controls.Add(this.JockeyIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteJockeyButton);
            this.Name = "DeleteJockeyForm";
            this.Text = "Delete Jockey";
            this.Load += new System.EventHandler(this.DeleteJockeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOCKEYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JockeyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button DeleteJockeyButton;
        private System.Windows.Forms.Label JockeyIDLabel;
        private NZHorseRacingDataSet nZHorseRacingDataSet;
        private System.Windows.Forms.BindingSource jOCKEYBindingSource;
        private NZHorseRacingDataSetTableAdapters.JOCKEYTableAdapter jOCKEYTableAdapter;
        private System.Windows.Forms.DataGridView JockeyDataGridView;
        private System.Windows.Forms.TextBox JockeyIDtextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn jockeyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    }
}