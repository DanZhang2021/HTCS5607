using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZHorsRacing
{
    public partial class DeleteRaceForm : Form
    {
        private datacontroller DC;
        private LoginForm frmLogin;
        private MainForm frmMenu;
        private CurrencyManager cmRace;
        private CurrencyManager cmMeeting;

        public DeleteRaceForm(datacontroller dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        private void DeleteRaceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nZHorseRacingDataSet.RACE' table. You can move, or remove it, as needed.
            this.rACETableAdapter.Fill(this.nZHorseRacingDataSet.RACE);
            Clearfields();
            
        }
        private void BindControls()
        {
            RaceIDTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Race.RaceID");
            RaceNameTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Race.RaceName");
            MeetingNameTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Meeting.MeetingName");
            cmRace = (CurrencyManager)this.BindingContext[DC.dsNZHorseRacing, "Race"];
            cmMeeting = (CurrencyManager)this.BindingContext[DC.dsNZHorseRacing, "Meeting"];
            RaceDataGridView.DataSource = DC.dsNZHorseRacing;
            RaceDataGridView.DataMember = "Race";
        }


        private void Clearfields()
        {
            MeetingNameTextBox.Text = "";
            RaceIDTextBox.Text = "";
            RaceNameTextBox.Text = "";
             }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void RaceDataGridView_Click(object sender, EventArgs e)
        {
            DataRow drRace = DC.dtRace.Rows[cmRace.Position];
            int anMeetingID = Convert.ToInt32(drRace["MeetingID"]);
            cmMeeting.Position = DC.meetingView.Find(anMeetingID);
            DataRow drMeeting = DC.dtMeeting.Rows[cmMeeting.Position];
            MeetingNameTextBox.Text = drMeeting["MeetingName"].ToString();
        }
        private void DeleteRaceButton_Click(object sender, EventArgs e)
        {
            DataRow deleteRaceRow = DC.dtRace.Rows[cmRace.Position];
            DialogResult dialogResultConfirm = MessageBox.Show("Are you sure you want to delete this race?",
                        "Ackonwledgment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResultConfirm == DialogResult.Yes)
            {
                deleteRaceRow.Delete();
                DC.UpdateRace();
                DialogResult dialogResult = MessageBox.Show("Race deleted succeffully,Would you like delete another one?",
                        "Ackonwledgment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Clearfields();

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                    frmMenu.Show();
                }
            }
            else if (dialogResultConfirm == DialogResult.No)
            {
                //Clearfields();

            }
            else if (dialogResultConfirm == DialogResult.Cancel)
            {
                this.Hide();
                frmMenu.Show();
            }

        }
    }
}
