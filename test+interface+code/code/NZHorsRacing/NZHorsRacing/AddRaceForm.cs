using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NZHorsRacing
{
    public partial class AddRaceForm : Form
    {
        private datacontroller DC;
        private LoginForm frmLogin;
        private MainForm frmMenu;

        public AddRaceForm(datacontroller dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }
        public void BindControls()
        {
            MeetingIDTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Meeting.MeetingID");
            MeetingDataGridView.DataSource = DC.dsNZHorseRacing;
            MeetingDataGridView.DataMember = "Meeting";
        }


        private void AddRaceForm_Load(object sender, EventArgs e)
        {
            clearFields();
            // TODO: This line of code loads data into the 'nZHorseRacingDataSet.MEETING' table. You can move, or remove it, as needed.
            this.mEETINGTableAdapter.Fill(this.nZHorseRacingDataSet.MEETING);
            // TODO: This line of code loads data into the 'nZHorseRacingDataSet.MEETING' table. You can move, or remove it, as needed.
            this.mEETINGTableAdapter.Fill(this.nZHorseRacingDataSet.MEETING);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mEETINGTableAdapter.FillBy(this.nZHorseRacingDataSet.MEETING);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void clearFields()
        {
            RaceNameTextBox.Text = "";
            RaceTimeTextBox.Text = "";
            StatusComboBox.Text = "";
            RaceTypeComboBox.Text = "";
            MeetingIDTextBox.Text = "";
        }


        private void AddRaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RaceNameTextBox.Text == "" || RaceTimeTextBox.Text == "" || StatusComboBox.Text == "" || RaceTypeComboBox.Text == "" || MeetingIDTextBox.Text == "")
                {
                    MessageBox.Show("Please fill all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataRow newRaceRow = DC.dtRace.NewRow();
                    newRaceRow["RaceName"] = RaceNameTextBox.Text;
                    newRaceRow["RaceTime"] = RaceTimeTextBox.Text;
                    newRaceRow["Status"] = StatusComboBox.Text;
                    newRaceRow["RaceType"] = RaceTypeComboBox.Text;
                    newRaceRow["MeetingID"] = MeetingIDTextBox.Text;
                    DC.dsNZHorseRacing.Tables["Race"].Rows.Add(newRaceRow);
                    DC.UpdateRace();
                    DialogResult dialogResult = MessageBox.Show("Race added successfully,would you like add another one?", "Acknowledgment", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        clearFields();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                        frmMenu.Show();
                    }
                }

            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Please file in all fields correctly.", "Error");
            }

        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
