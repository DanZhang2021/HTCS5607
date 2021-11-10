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
    public partial class AddJockeyForm : Form
    {
        private datacontroller DC;
        private LoginForm frmLogin;
        private MainForm frmMenu;

        public AddJockeyForm(datacontroller dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        private void Clearfields()
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            EmailAddressTextBox.Text = "";
            WeightTextBox.Text = "";
            DateOfBirthDateTimePicker.Value = DateTime.Today;
        }

        private void AddJockeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newJockeyRow = DC.dtJockey.NewRow();
                if (LastNameTextBox.Text == "" || FirstNameTextBox.Text == "" || EmailAddressTextBox.Text == "" ||
                    WeightTextBox.Text == "" || DateOfBirthDateTimePicker.Text == "")
                {
                    MessageBox.Show("Please fill all the required fields.", "Error");
                }
                else
                {
                    newJockeyRow["LastName"] = LastNameTextBox.Text;
                    newJockeyRow["FirstName"] = FirstNameTextBox.Text;
                    newJockeyRow["EmailAddress"] = EmailAddressTextBox.Text;
                    newJockeyRow["Weight"] = WeightTextBox.Text;
                    newJockeyRow["DateOfBirth"] = DateOfBirthDateTimePicker.Text;
                    DC.dsNZHorseRacing.Tables["Jockey"].Rows.Add(newJockeyRow);
                    DC.UpdateJockey();
                    DialogResult dialogResult = MessageBox.Show("Jockey added successfully.Would you want to add another one?",
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
            }
            catch(System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Please file in all fields correctly.", "Error");
            }
        }
    }
}
