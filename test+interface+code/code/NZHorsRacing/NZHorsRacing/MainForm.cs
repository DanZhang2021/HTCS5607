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
    public partial class MainForm : Form
    {

        private datacontroller DC;
        private AddJockeyForm frmAddJockey;
        private AddRaceForm frmAddRace;
        private UpdateJockeyForm frmUpdateJockey;
        private UpdateRaceForm frmUpdateRace;
        private UpdateRaceEntryForm frmUpdateRaceEntry;
        private DeleteJockeyForm frmDeleteJockey;
        private DeleteRaceForm frmDeleteRace;
        private RaceReportForm frmRaceReport;
       // private MainForm frmMenu;
        private LoginForm loginForm;


        public MainForm(datacontroller dC, LoginForm loginForm)
        {
            InitializeComponent();
            DC = dC;
            this.loginForm = loginForm;
            loginForm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new datacontroller();
        }

        private void AddJockeybutton_Click(object sender, EventArgs e)
        {
            if (frmAddJockey == null)
            {
                frmAddJockey = new AddJockeyForm(DC, this);
            }
            frmAddJockey.ShowDialog();
        }

        private void AddRacebutton_Click(object sender, EventArgs e)
        {
            if (frmAddRace == null)
            {
                frmAddRace = new AddRaceForm(DC, this);
            }
            frmAddRace.ShowDialog();
        }

        private void UpdateJockeybutton_Click(object sender, EventArgs e)
        {
            if (frmUpdateJockey == null)
            {
                frmUpdateJockey = new UpdateJockeyForm(DC, this);
            }
            frmUpdateJockey.ShowDialog();
        }

        private void UpdateRacebutton_Click(object sender, EventArgs e)
        {
            if (frmUpdateRace == null)
            {
                frmUpdateRace = new UpdateRaceForm(DC, this);
            }
            frmUpdateRace.ShowDialog();
        }

        private void DeleteJockeybutton_Click(object sender, EventArgs e)
        {
            if (frmDeleteJockey == null)
            {
                frmDeleteJockey = new DeleteJockeyForm(DC, this);
            }
            frmDeleteJockey.ShowDialog();
        }

        private void DeleteRacebutton_Click(object sender, EventArgs e)
        {
            if (frmDeleteRace == null)
            {
                frmDeleteRace = new DeleteRaceForm(DC, this);
            }
            frmDeleteRace.ShowDialog();
        }

        private void UpdateRaceEntrybutton_Click(object sender, EventArgs e)
        {
            if (frmUpdateRaceEntry == null)
            {
                frmUpdateRaceEntry = new UpdateRaceEntryForm(DC, this);
            }
            frmUpdateRaceEntry.ShowDialog();
        }

        private void RaceReportbutton_Click(object sender, EventArgs e)
        {
            if (frmRaceReport == null)
            {
                frmRaceReport = new RaceReportForm(DC, this);
            }
            frmRaceReport.ShowDialog();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
