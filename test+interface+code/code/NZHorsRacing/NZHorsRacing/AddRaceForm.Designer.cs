
namespace NZHorsRacing
{
    partial class AddRaceForm
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
            this.RaceNameLabel = new System.Windows.Forms.Label();
            this.RaceTimeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RaceTypeLabel = new System.Windows.Forms.Label();
            this.MeetingIDlabel = new System.Windows.Forms.Label();
            this.RaceNameTextBox = new System.Windows.Forms.TextBox();
            this.mEETINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nZHorseRacingDataSet = new NZHorsRacing.NZHorseRacingDataSet();
            this.AddRaceButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.RaceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MeetingIDTextBox = new System.Windows.Forms.TextBox();
            this.MeetingDataGridView = new System.Windows.Forms.DataGridView();
            this.meetingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEETINGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mEETINGTableAdapter = new NZHorsRacing.NZHorseRacingDataSetTableAdapters.MEETINGTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.RaceTimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mEETINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeetingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEETINGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RaceNameLabel
            // 
            this.RaceNameLabel.AutoSize = true;
            this.RaceNameLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceNameLabel.Location = new System.Drawing.Point(189, 154);
            this.RaceNameLabel.Name = "RaceNameLabel";
            this.RaceNameLabel.Size = new System.Drawing.Size(103, 18);
            this.RaceNameLabel.TabIndex = 2;
            this.RaceNameLabel.Text = "Race Name:";
            // 
            // RaceTimeLabel
            // 
            this.RaceTimeLabel.AutoSize = true;
            this.RaceTimeLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTimeLabel.Location = new System.Drawing.Point(196, 188);
            this.RaceTimeLabel.Name = "RaceTimeLabel";
            this.RaceTimeLabel.Size = new System.Drawing.Size(96, 18);
            this.RaceTimeLabel.TabIndex = 3;
            this.RaceTimeLabel.Text = "Race Time:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(230, 222);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(62, 18);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status:";
            // 
            // RaceTypeLabel
            // 
            this.RaceTypeLabel.AutoSize = true;
            this.RaceTypeLabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTypeLabel.Location = new System.Drawing.Point(194, 256);
            this.RaceTypeLabel.Name = "RaceTypeLabel";
            this.RaceTypeLabel.Size = new System.Drawing.Size(98, 18);
            this.RaceTypeLabel.TabIndex = 5;
            this.RaceTypeLabel.Text = "Race Type:";
            // 
            // MeetingIDlabel
            // 
            this.MeetingIDlabel.AutoSize = true;
            this.MeetingIDlabel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingIDlabel.Location = new System.Drawing.Point(196, 294);
            this.MeetingIDlabel.Name = "MeetingIDlabel";
            this.MeetingIDlabel.Size = new System.Drawing.Size(100, 18);
            this.MeetingIDlabel.TabIndex = 6;
            this.MeetingIDlabel.Text = "Meeting ID:";
            // 
            // RaceNameTextBox
            // 
            this.RaceNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceNameTextBox.Location = new System.Drawing.Point(298, 150);
            this.RaceNameTextBox.Multiline = true;
            this.RaceNameTextBox.Name = "RaceNameTextBox";
            this.RaceNameTextBox.Size = new System.Drawing.Size(237, 30);
            this.RaceNameTextBox.TabIndex = 7;
            // 
            // mEETINGBindingSource
            // 
            this.mEETINGBindingSource.DataMember = "MEETING";
            this.mEETINGBindingSource.DataSource = this.nZHorseRacingDataSet;
            // 
            // nZHorseRacingDataSet
            // 
            this.nZHorseRacingDataSet.DataSetName = "NZHorseRacingDataSet";
            this.nZHorseRacingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddRaceButton
            // 
            this.AddRaceButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddRaceButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRaceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRaceButton.Location = new System.Drawing.Point(86, 464);
            this.AddRaceButton.Name = "AddRaceButton";
            this.AddRaceButton.Size = new System.Drawing.Size(150, 50);
            this.AddRaceButton.TabIndex = 17;
            this.AddRaceButton.Text = "Add Race";
            this.AddRaceButton.UseVisualStyleBackColor = false;
            this.AddRaceButton.Click += new System.EventHandler(this.AddRaceButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReturnButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnButton.Location = new System.Drawing.Point(380, 464);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(150, 50);
            this.ReturnButton.TabIndex = 18;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Scheduled",
            "Finished"});
            this.StatusComboBox.Location = new System.Drawing.Point(298, 222);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 28);
            this.StatusComboBox.TabIndex = 19;
            // 
            // RaceTypeComboBox
            // 
            this.RaceTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTypeComboBox.FormattingEnabled = true;
            this.RaceTypeComboBox.Items.AddRange(new object[] {
            "Hurdles",
            "Chase",
            "Handicap",
            "Flat"});
            this.RaceTypeComboBox.Location = new System.Drawing.Point(298, 256);
            this.RaceTypeComboBox.Name = "RaceTypeComboBox";
            this.RaceTypeComboBox.Size = new System.Drawing.Size(95, 28);
            this.RaceTypeComboBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter the Race\'s detal that you want to add:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 48);
            this.label2.TabIndex = 31;
            this.label2.Text = "Add Race";
            // 
            // MeetingIDTextBox
            // 
            this.MeetingIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingIDTextBox.Location = new System.Drawing.Point(298, 290);
            this.MeetingIDTextBox.Multiline = true;
            this.MeetingIDTextBox.Name = "MeetingIDTextBox";
            this.MeetingIDTextBox.Size = new System.Drawing.Size(85, 30);
            this.MeetingIDTextBox.TabIndex = 33;
            // 
            // MeetingDataGridView
            // 
            this.MeetingDataGridView.AutoGenerateColumns = false;
            this.MeetingDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MeetingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeetingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meetingIDDataGridViewTextBoxColumn,
            this.meetingNameDataGridViewTextBoxColumn});
            this.MeetingDataGridView.DataSource = this.mEETINGBindingSource1;
            this.MeetingDataGridView.Location = new System.Drawing.Point(180, 349);
            this.MeetingDataGridView.Name = "MeetingDataGridView";
            this.MeetingDataGridView.Size = new System.Drawing.Size(288, 100);
            this.MeetingDataGridView.TabIndex = 34;
            // 
            // meetingIDDataGridViewTextBoxColumn
            // 
            this.meetingIDDataGridViewTextBoxColumn.DataPropertyName = "MeetingID";
            this.meetingIDDataGridViewTextBoxColumn.HeaderText = "MeetingID";
            this.meetingIDDataGridViewTextBoxColumn.Name = "meetingIDDataGridViewTextBoxColumn";
            // 
            // meetingNameDataGridViewTextBoxColumn
            // 
            this.meetingNameDataGridViewTextBoxColumn.DataPropertyName = "MeetingName";
            this.meetingNameDataGridViewTextBoxColumn.HeaderText = "MeetingName";
            this.meetingNameDataGridViewTextBoxColumn.Name = "meetingNameDataGridViewTextBoxColumn";
            // 
            // mEETINGBindingSource1
            // 
            this.mEETINGBindingSource1.DataMember = "MEETING";
            this.mEETINGBindingSource1.DataSource = this.nZHorseRacingDataSet;
            // 
            // mEETINGTableAdapter
            // 
            this.mEETINGTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Choose the meeting that the race belong to:";
            // 
            // RaceTimeTextBox
            // 
            this.RaceTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTimeTextBox.Location = new System.Drawing.Point(298, 186);
            this.RaceTimeTextBox.Multiline = true;
            this.RaceTimeTextBox.Name = "RaceTimeTextBox";
            this.RaceTimeTextBox.Size = new System.Drawing.Size(95, 30);
            this.RaceTimeTextBox.TabIndex = 37;
            this.RaceTimeTextBox.Text = "9:00";
            // 
            // AddRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 561);
            this.Controls.Add(this.RaceTimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeetingDataGridView);
            this.Controls.Add(this.MeetingIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaceTypeComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.AddRaceButton);
            this.Controls.Add(this.RaceNameTextBox);
            this.Controls.Add(this.MeetingIDlabel);
            this.Controls.Add(this.RaceTypeLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.RaceTimeLabel);
            this.Controls.Add(this.RaceNameLabel);
            this.Name = "AddRaceForm";
            this.Text = "Add Race";
            this.Load += new System.EventHandler(this.AddRaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEETINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZHorseRacingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeetingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEETINGBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RaceNameLabel;
        private System.Windows.Forms.Label RaceTimeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label RaceTypeLabel;
        private System.Windows.Forms.Label MeetingIDlabel;
        private System.Windows.Forms.TextBox RaceNameTextBox;
        private NZHorseRacingDataSet nZHorseRacingDataSet;
        private System.Windows.Forms.BindingSource mEETINGBindingSource;
        private System.Windows.Forms.Button AddRaceButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox RaceTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MeetingIDTextBox;
        private System.Windows.Forms.DataGridView MeetingDataGridView;
        private System.Windows.Forms.BindingSource mEETINGBindingSource1;
        private NZHorseRacingDataSetTableAdapters.MEETINGTableAdapter mEETINGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RaceTimeTextBox;
    }
}