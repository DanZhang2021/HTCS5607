
namespace NZHorsRacing
{
    partial class DeleteRaceForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DeleteRaceButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.RaceNameTextBox = new System.Windows.Forms.TextBox();
            this.MeetingNamelabel = new System.Windows.Forms.Label();
            this.RaceIDLabel = new System.Windows.Forms.Label();
            this.RaceNameLabel = new System.Windows.Forms.Label();
            this.RaceIDTextBox = new System.Windows.Forms.TextBox();
            this.RaceDataGridView = new System.Windows.Forms.DataGridView();
            this.raceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rACEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nZHorseRacingDataSet = new NZHorsRacing.NZHorseRacingDataSet();
            this.rACETableAdapter = new NZHorsRacing.NZHorseRacingDataSetTableAdapters.RACETableAdapter();
            this.MeetingNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RaceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Choose one Race that you want to delete:";
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnButton.Location = new System.Drawing.Point(422, 434);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(150, 50);
            this.ReturnButton.TabIndex = 32;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DeleteRaceButton
            // 
            this.DeleteRaceButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteRaceButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRaceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteRaceButton.Location = new System.Drawing.Point(107, 434);
            this.DeleteRaceButton.Name = "DeleteRaceButton";
            this.DeleteRaceButton.Size = new System.Drawing.Size(150, 50);
            this.DeleteRaceButton.TabIndex = 31;
            this.DeleteRaceButton.Text = "Delete Race";
            this.DeleteRaceButton.UseVisualStyleBackColor = false;
            this.DeleteRaceButton.Click += new System.EventHandler(this.DeleteRaceButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(168, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(339, 48);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Delete Race";
            // 
            // RaceNameTextBox
            // 
            this.RaceNameTextBox.Enabled = false;
            this.RaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceNameTextBox.Location = new System.Drawing.Point(422, 241);
            this.RaceNameTextBox.Multiline = true;
            this.RaceNameTextBox.Name = "RaceNameTextBox";
            this.RaceNameTextBox.Size = new System.Drawing.Size(205, 30);
            this.RaceNameTextBox.TabIndex = 27;
            // 
            // MeetingNamelabel
            // 
            this.MeetingNamelabel.AutoSize = true;
            this.MeetingNamelabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingNamelabel.Location = new System.Drawing.Point(281, 287);
            this.MeetingNamelabel.Name = "MeetingNamelabel";
            this.MeetingNamelabel.Size = new System.Drawing.Size(127, 18);
            this.MeetingNamelabel.TabIndex = 26;
            this.MeetingNamelabel.Text = "Meeting Name:";
            // 
            // RaceIDLabel
            // 
            this.RaceIDLabel.AutoSize = true;
            this.RaceIDLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceIDLabel.Location = new System.Drawing.Point(332, 197);
            this.RaceIDLabel.Name = "RaceIDLabel";
            this.RaceIDLabel.Size = new System.Drawing.Size(76, 18);
            this.RaceIDLabel.TabIndex = 22;
            this.RaceIDLabel.Text = "Race ID:";
            // 
            // RaceNameLabel
            // 
            this.RaceNameLabel.AutoSize = true;
            this.RaceNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceNameLabel.Location = new System.Drawing.Point(305, 242);
            this.RaceNameLabel.Name = "RaceNameLabel";
            this.RaceNameLabel.Size = new System.Drawing.Size(103, 18);
            this.RaceNameLabel.TabIndex = 36;
            this.RaceNameLabel.Text = "Race Name:";
            // 
            // RaceIDTextBox
            // 
            this.RaceIDTextBox.Enabled = false;
            this.RaceIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceIDTextBox.Location = new System.Drawing.Point(422, 189);
            this.RaceIDTextBox.Multiline = true;
            this.RaceIDTextBox.Name = "RaceIDTextBox";
            this.RaceIDTextBox.Size = new System.Drawing.Size(65, 30);
            this.RaceIDTextBox.TabIndex = 37;
            // 
            // RaceDataGridView
            // 
            this.RaceDataGridView.AllowUserToAddRows = false;
            this.RaceDataGridView.AllowUserToDeleteRows = false;
            this.RaceDataGridView.AutoGenerateColumns = false;
            this.RaceDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.RaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RaceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raceIDDataGridViewTextBoxColumn,
            this.raceNameDataGridViewTextBoxColumn});
            this.RaceDataGridView.DataSource = this.rACEBindingSource;
            this.RaceDataGridView.Location = new System.Drawing.Point(17, 151);
            this.RaceDataGridView.Name = "RaceDataGridView";
            this.RaceDataGridView.ReadOnly = true;
            this.RaceDataGridView.Size = new System.Drawing.Size(240, 242);
            this.RaceDataGridView.TabIndex = 38;
            this.RaceDataGridView.Click += new System.EventHandler(this.RaceDataGridView_Click);
            // 
            // raceIDDataGridViewTextBoxColumn
            // 
            this.raceIDDataGridViewTextBoxColumn.DataPropertyName = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.HeaderText = "RaceID";
            this.raceIDDataGridViewTextBoxColumn.Name = "raceIDDataGridViewTextBoxColumn";
            this.raceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // raceNameDataGridViewTextBoxColumn
            // 
            this.raceNameDataGridViewTextBoxColumn.DataPropertyName = "RaceName";
            this.raceNameDataGridViewTextBoxColumn.HeaderText = "RaceName";
            this.raceNameDataGridViewTextBoxColumn.Name = "raceNameDataGridViewTextBoxColumn";
            this.raceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rACEBindingSource
            // 
            this.rACEBindingSource.DataMember = "RACE";
            this.rACEBindingSource.DataSource = this.nZHorseRacingDataSet;
            // 
            // nZHorseRacingDataSet
            // 
            this.nZHorseRacingDataSet.DataSetName = "NZHorseRacingDataSet";
            this.nZHorseRacingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rACETableAdapter
            // 
            this.rACETableAdapter.ClearBeforeFill = true;
            // 
            // MeetingNameTextBox
            // 
            this.MeetingNameTextBox.Enabled = false;
            this.MeetingNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingNameTextBox.Location = new System.Drawing.Point(422, 288);
            this.MeetingNameTextBox.Multiline = true;
            this.MeetingNameTextBox.Name = "MeetingNameTextBox";
            this.MeetingNameTextBox.Size = new System.Drawing.Size(205, 30);
            this.MeetingNameTextBox.TabIndex = 39;
            // 
            // DeleteRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.MeetingNameTextBox);
            this.Controls.Add(this.RaceDataGridView);
            this.Controls.Add(this.RaceIDTextBox);
            this.Controls.Add(this.RaceNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.DeleteRaceButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.RaceNameTextBox);
            this.Controls.Add(this.MeetingNamelabel);
            this.Controls.Add(this.RaceIDLabel);
            this.Name = "DeleteRaceForm";
            this.Text = "Delete Race";
            this.Load += new System.EventHandler(this.DeleteRaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rACEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button DeleteRaceButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox RaceNameTextBox;
        private System.Windows.Forms.Label MeetingNamelabel;
        private System.Windows.Forms.Label RaceIDLabel;
        private System.Windows.Forms.Label RaceNameLabel;
        private System.Windows.Forms.TextBox RaceIDTextBox;
        private System.Windows.Forms.DataGridView RaceDataGridView;
        private NZHorseRacingDataSet nZHorseRacingDataSet;
        private System.Windows.Forms.BindingSource rACEBindingSource;
        private NZHorseRacingDataSetTableAdapters.RACETableAdapter rACETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox MeetingNameTextBox;
    }
}