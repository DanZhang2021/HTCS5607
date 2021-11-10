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
    public partial class datacontroller : Form
    {
        public DataTable dtMeeting;
        public DataTable dtBooking;
        public DataTable dtCustomer;
        public DataTable dtHorse;
        public DataTable dtOwner;
        public DataTable dtJockey;
        public DataTable dtRace;
        public DataTable dtRaceEntry;
        public DataTable dtRaceCourse;
        public DataView bookingView;
        public DataView customerView;
        public DataView horseView;
        public DataView jockeyView;
        public DataView meetingView;
        public DataView ownerView;
        public DataView raceView;
        public DataView racecourseView;
        public DataView raceentryView;




        public datacontroller()
        {
            InitializeComponent();
            dsNZHorseRacing.EnforceConstraints = false;
            daBooking.Fill(dsNZHorseRacing);
            daCustomer.Fill(dsNZHorseRacing);
            daHorse.Fill(dsNZHorseRacing);
            daJockey.Fill(dsNZHorseRacing);
            daMeeting.Fill(dsNZHorseRacing);
            daOwner.Fill(dsNZHorseRacing);
            daRace.Fill(dsNZHorseRacing);
            daRaceCourse.Fill(dsNZHorseRacing);
            daRaceEntry.Fill(dsNZHorseRacing);
            dtBooking = dsNZHorseRacing.Tables["Booking"];
            dtCustomer = dsNZHorseRacing.Tables["Customer"];
            dtHorse = dsNZHorseRacing.Tables["Horse"];
            dtJockey = dsNZHorseRacing.Tables["Jockey"];
            dtMeeting = dsNZHorseRacing.Tables["Meeting"];
            dtOwner = dsNZHorseRacing.Tables["Owner"];
            dtRace = dsNZHorseRacing.Tables["Race"];
            dtRaceCourse = dsNZHorseRacing.Tables["Race Course"];
            dtRaceEntry = dsNZHorseRacing.Tables["Race Entry"];
            bookingView = new DataView(dtBooking);
            bookingView.Sort = "BookingID";
            customerView = new DataView(dtCustomer);
            customerView.Sort ="CustomerID";
            horseView = new DataView(dtHorse);
            horseView.Sort = "HorseID";
            jockeyView = new DataView(dtJockey);
            jockeyView.Sort = "JockeyID";
            meetingView = new DataView(dtMeeting);
            meetingView.Sort = "MeetingID";
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            raceView = new DataView(dtRace);
            raceView.Sort = "RaceID";
            racecourseView = new DataView(dtRaceCourse);
            racecourseView.Sort = "RaceCourseID";
            raceentryView = new DataView(dtRaceEntry);
            raceentryView.Sort = "RaceEntryID";
            //dsNZHorseRacing.EnforceConstraints = true;
        }
        public void UpdateRace()
        {
            daRace.Update(dsNZHorseRacing, "Race");
        }
        private void daRace_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZHorseRacing);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RaceID"] = newID;
            }
        }
        public void UpdateJockey()
        {
           daJockey.Update(dsNZHorseRacing, "Jockey");
        }
        private void daJockey_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnNZHorseRacing);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["JockeyID"] = newID;
            }
        }
        public void UpdateRaceEntry()
        {
            daRaceEntry.Update(dsNZHorseRacing, "Race Entry");
        }

    }
}
