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
    public partial class DeleteJockeyForm : Form
    {
        private datacontroller DC;
        private LoginForm frmLogin;
        private MainForm frmMenu;
        private CurrencyManager cmJockey;

        public DeleteJockeyForm(datacontroller dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        private void DeleteJockeyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nZHorseRacingDataSet.RACE_ENTRY' table. You can move, or remove it, as needed.
            //this.rACE_ENTRYTableAdapter.Fill(this.nZHorseRacingDataSet.RACE_ENTRY);
            // TODO: This line of code loads data into the 'nZHorseRacingDataSet.JOCKEY' table. You can move, or remove it, as needed.
            this.jOCKEYTableAdapter.Fill(this.nZHorseRacingDataSet.JOCKEY);
            Clearfields();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
        public void BindControls()
        {
            JockeyIDtextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Jockey.JockeyID");
            LastNameTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Jockey.LastName");
            FirstNameTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Jockey.FirstName");
            WeightTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Jockey.Weight");
            DateOfBirthTextBox.DataBindings.Add("Text", DC.dsNZHorseRacing, "Jockey.DateOfBirth");
            cmJockey = (CurrencyManager)this.BindingContext[DC.dsNZHorseRacing, "Jockey"];
            JockeyDataGridView.DataSource = DC.dsNZHorseRacing;
            JockeyDataGridView.DataMember = "Jockey";            
        }
        private void Clearfields()
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            JockeyIDtextBox.Text = "";
            WeightTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
        }
        private void DeleteJockeyButton_Click(object sender, EventArgs e)
        {
            DataRow deleteJockeyRow = DC.dtJockey.Rows[cmJockey.Position];
            DialogResult dialogResultConfirm = MessageBox.Show("Are you sure you want to delete this jockey?",
                        "Ackonwledgment", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResultConfirm == DialogResult.Yes)
            {
                deleteJockeyRow.Delete();
                DC.UpdateJockey();
                DialogResult dialogResult = MessageBox.Show("Jockey deleted succeffully,Would you like delete another one?",
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
