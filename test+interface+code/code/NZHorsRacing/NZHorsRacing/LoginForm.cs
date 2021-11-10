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
    public partial class LoginForm : Form
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
        private MainForm frmMenu;



        public LoginForm()
        {
            InitializeComponent();
            DC = new datacontroller();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddJockeyButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                if (frmMenu == null)
                {
                    frmMenu = new MainForm(DC, this);
                }
                frmMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("The username or the password is wrong,please try angin.", "Error");
            }
        }
    }
}
