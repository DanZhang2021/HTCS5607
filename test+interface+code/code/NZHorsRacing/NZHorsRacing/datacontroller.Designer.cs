
namespace NZHorsRacing
{
    partial class datacontroller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datacontroller));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnNZHorseRacing = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daBooking = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daCustomer = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daHorse = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daJockey = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daMeeting = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daOwner = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daRace = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
            this.daRaceCourse = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand9 = new System.Data.OleDb.OleDbCommand();
            this.daRaceEntry = new System.Data.OleDb.OleDbDataAdapter();
            this.dsNZHorseRacing = new NZHorsRacing.NZHorseRacingDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dsNZHorseRacing)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        BOOKING.*\r\nFROM            BOOKING\r\nORDER BY BookingID";
            this.oleDbSelectCommand1.Connection = this.ctnNZHorseRacing;
            // 
            // ctnNZHorseRacing
            // 
            this.ctnNZHorseRacing.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\5607\\NZHorseRacing.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `BOOKING` (`Quantity`, `Status`, `BookingDate`, `CustomerID`, `Meetin" +
    "gID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Integer, 0, "Quantity"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("BookingDate", System.Data.OleDb.OleDbType.Date, 0, "BookingDate"),
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 0, "CustomerID"),
            new System.Data.OleDb.OleDbParameter("MeetingID", System.Data.OleDb.OleDbType.Integer, 0, "MeetingID")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Quantity", System.Data.OleDb.OleDbType.Integer, 0, "Quantity"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("BookingDate", System.Data.OleDb.OleDbType.Date, 0, "BookingDate"),
            new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 0, "CustomerID"),
            new System.Data.OleDb.OleDbParameter("MeetingID", System.Data.OleDb.OleDbType.Integer, 0, "MeetingID"),
            new System.Data.OleDb.OleDbParameter("Original_BookingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookingID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BookingDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BookingDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BookingDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookingDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_BookingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookingID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Quantity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BookingDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BookingDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BookingDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BookingDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null)});
            // 
            // daBooking
            // 
            this.daBooking.DeleteCommand = this.oleDbDeleteCommand1;
            this.daBooking.InsertCommand = this.oleDbInsertCommand1;
            this.daBooking.SelectCommand = this.oleDbSelectCommand1;
            this.daBooking.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BOOKING", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("BookingID", "BookingID"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("BookingDate", "BookingDate"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("MeetingID", "MeetingID")})});
            this.daBooking.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        CUSTOMER.*\r\nFROM            CUSTOMER\r\nORDER BY CustomerID";
            this.oleDbSelectCommand2.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `CUSTOMER` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City" +
    "`, `EmailAddress`, `PhoneNumber`, `CreditStatus`) VALUES (?, ?, ?, ?, ?, ?, ?, ?" +
    ")";
            this.oleDbInsertCommand2.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "CreditStatus")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, "CreditStatus"),
            new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CreditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CreditStatus", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CreditStatus", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CreditStatus", System.Data.DataRowVersion.Original, null)});
            // 
            // daCustomer
            // 
            this.daCustomer.DeleteCommand = this.oleDbDeleteCommand2;
            this.daCustomer.InsertCommand = this.oleDbInsertCommand2;
            this.daCustomer.SelectCommand = this.oleDbSelectCommand2;
            this.daCustomer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CUSTOMER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("CreditStatus", "CreditStatus")})});
            this.daCustomer.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        HORSE.*\r\nFROM            HORSE\r\nORDER BY HorseID";
            this.oleDbSelectCommand3.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `HORSE` (`HorseName`, `Gender`, `DateOfBirth`, `OwnerID`) VALUES (?, " +
    "?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("HorseName", System.Data.OleDb.OleDbType.VarWChar, 0, "HorseName"),
            new System.Data.OleDb.OleDbParameter("Gender", System.Data.OleDb.OleDbType.VarWChar, 0, "Gender"),
            new System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, "DateOfBirth"),
            new System.Data.OleDb.OleDbParameter("OwnerID", System.Data.OleDb.OleDbType.LongVarWChar, 0, "OwnerID")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("HorseName", System.Data.OleDb.OleDbType.VarWChar, 0, "HorseName"),
            new System.Data.OleDb.OleDbParameter("Gender", System.Data.OleDb.OleDbType.VarWChar, 0, "Gender"),
            new System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, "DateOfBirth"),
            new System.Data.OleDb.OleDbParameter("OwnerID", System.Data.OleDb.OleDbType.LongVarWChar, 0, "OwnerID"),
            new System.Data.OleDb.OleDbParameter("Original_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HorseName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HorseName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HorseName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Gender", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Gender", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOfBirth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HorseName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HorseName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HorseName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Gender", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Gender", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Gender", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOfBirth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, null)});
            // 
            // daHorse
            // 
            this.daHorse.DeleteCommand = this.oleDbDeleteCommand3;
            this.daHorse.InsertCommand = this.oleDbInsertCommand3;
            this.daHorse.SelectCommand = this.oleDbSelectCommand3;
            this.daHorse.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "HORSE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("HorseID", "HorseID"),
                        new System.Data.Common.DataColumnMapping("HorseName", "HorseName"),
                        new System.Data.Common.DataColumnMapping("Gender", "Gender"),
                        new System.Data.Common.DataColumnMapping("DateOfBirth", "DateOfBirth"),
                        new System.Data.Common.DataColumnMapping("OwnerID", "OwnerID")})});
            this.daHorse.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        JOCKEY.*\r\nFROM            JOCKEY\r\nORDER BY JockeyID";
            this.oleDbSelectCommand4.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `JOCKEY` (`LastName`, `FirstName`, `EmailAddress`, `Weight`, `DateOfB" +
    "irth`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.VarWChar, 0, "Weight"),
            new System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, "DateOfBirth")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.VarWChar, 0, "Weight"),
            new System.Data.OleDb.OleDbParameter("DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, "DateOfBirth"),
            new System.Data.OleDb.OleDbParameter("Original_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOfBirth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Weight", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOfBirth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOfBirth", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOfBirth", System.Data.DataRowVersion.Original, null)});
            // 
            // daJockey
            // 
            this.daJockey.DeleteCommand = this.oleDbDeleteCommand4;
            this.daJockey.InsertCommand = this.oleDbInsertCommand4;
            this.daJockey.SelectCommand = this.oleDbSelectCommand4;
            this.daJockey.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "JOCKEY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("JockeyID", "JockeyID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("Weight", "Weight"),
                        new System.Data.Common.DataColumnMapping("DateOfBirth", "DateOfBirth")})});
            this.daJockey.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        MEETING.*\r\nFROM            MEETING\r\nORDER BY MeetingID";
            this.oleDbSelectCommand5.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `MEETING` (`MeetingName`, `MeetingDate`, `TicketPrice`, `Capacity`, `" +
    "RaceCourseID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MeetingName", System.Data.OleDb.OleDbType.VarWChar, 0, "MeetingName"),
            new System.Data.OleDb.OleDbParameter("MeetingDate", System.Data.OleDb.OleDbType.Date, 0, "MeetingDate"),
            new System.Data.OleDb.OleDbParameter("TicketPrice", System.Data.OleDb.OleDbType.Currency, 0, "TicketPrice"),
            new System.Data.OleDb.OleDbParameter("Capacity", System.Data.OleDb.OleDbType.Integer, 0, "Capacity"),
            new System.Data.OleDb.OleDbParameter("RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, "RaceCourseID")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MeetingName", System.Data.OleDb.OleDbType.VarWChar, 0, "MeetingName"),
            new System.Data.OleDb.OleDbParameter("MeetingDate", System.Data.OleDb.OleDbType.Date, 0, "MeetingDate"),
            new System.Data.OleDb.OleDbParameter("TicketPrice", System.Data.OleDb.OleDbType.Currency, 0, "TicketPrice"),
            new System.Data.OleDb.OleDbParameter("Capacity", System.Data.OleDb.OleDbType.Integer, 0, "Capacity"),
            new System.Data.OleDb.OleDbParameter("RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, "RaceCourseID"),
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TicketPrice", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TicketPrice", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TicketPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TicketPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TicketPrice", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TicketPrice", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TicketPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TicketPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, null)});
            // 
            // daMeeting
            // 
            this.daMeeting.DeleteCommand = this.oleDbDeleteCommand5;
            this.daMeeting.InsertCommand = this.oleDbInsertCommand5;
            this.daMeeting.SelectCommand = this.oleDbSelectCommand5;
            this.daMeeting.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MEETING", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MeetingID", "MeetingID"),
                        new System.Data.Common.DataColumnMapping("MeetingName", "MeetingName"),
                        new System.Data.Common.DataColumnMapping("MeetingDate", "MeetingDate"),
                        new System.Data.Common.DataColumnMapping("TicketPrice", "TicketPrice"),
                        new System.Data.Common.DataColumnMapping("Capacity", "Capacity"),
                        new System.Data.Common.DataColumnMapping("RaceCourseID", "RaceCourseID")})});
            this.daMeeting.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT        OWNER.*\r\nFROM            OWNER\r\nORDER BY OwnerID";
            this.oleDbSelectCommand6.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `OWNER` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City`, " +
    "`EmailAddress`, `PhoneNumber`, `NZRAMember`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("NZRAMember", System.Data.OleDb.OleDbType.Boolean, 0, "NZRAMember")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("NZRAMember", System.Data.OleDb.OleDbType.Boolean, 0, "NZRAMember"),
            new System.Data.OleDb.OleDbParameter("Original_OwnerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OwnerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_NZRAMember", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NZRAMember", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_NZRAMember", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NZRAMember", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_OwnerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OwnerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_NZRAMember", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "NZRAMember", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_NZRAMember", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NZRAMember", System.Data.DataRowVersion.Original, null)});
            // 
            // daOwner
            // 
            this.daOwner.DeleteCommand = this.oleDbDeleteCommand6;
            this.daOwner.InsertCommand = this.oleDbInsertCommand6;
            this.daOwner.SelectCommand = this.oleDbSelectCommand6;
            this.daOwner.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "OWNER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OwnerID", "OwnerID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("NZRAMember", "NZRAMember")})});
            this.daOwner.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT        RACE.*\r\nFROM            RACE\r\nORDER BY RaceID";
            this.oleDbSelectCommand7.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `RACE` (`RaceName`, `RaceTime`, `Status`, `RaceType`, `MeetingID`) VA" +
    "LUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RaceName", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceName"),
            new System.Data.OleDb.OleDbParameter("RaceTime", System.Data.OleDb.OleDbType.Date, 0, "RaceTime"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("RaceType", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceType"),
            new System.Data.OleDb.OleDbParameter("MeetingID", System.Data.OleDb.OleDbType.Integer, 0, "MeetingID")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RaceName", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceName"),
            new System.Data.OleDb.OleDbParameter("RaceTime", System.Data.OleDb.OleDbType.Date, 0, "RaceTime"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("RaceType", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceType"),
            new System.Data.OleDb.OleDbParameter("MeetingID", System.Data.OleDb.OleDbType.Integer, 0, "MeetingID"),
            new System.Data.OleDb.OleDbParameter("Original_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceTime", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceTime", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceTime", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceTime", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceTime", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceTime", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MeetingID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MeetingID", System.Data.DataRowVersion.Original, null)});
            // 
            // daRace
            // 
            this.daRace.DeleteCommand = this.oleDbDeleteCommand7;
            this.daRace.InsertCommand = this.oleDbInsertCommand7;
            this.daRace.SelectCommand = this.oleDbSelectCommand7;
            this.daRace.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RACE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("RaceID", "RaceID"),
                        new System.Data.Common.DataColumnMapping("RaceName", "RaceName"),
                        new System.Data.Common.DataColumnMapping("RaceTime", "RaceTime"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("RaceType", "RaceType"),
                        new System.Data.Common.DataColumnMapping("MeetingID", "MeetingID")})});
            this.daRace.UpdateCommand = this.oleDbUpdateCommand7;
            // 
            // oleDbSelectCommand8
            // 
            this.oleDbSelectCommand8.CommandText = "SELECT        [RACE COURSE].*\r\nFROM            [RACE COURSE]\r\nORDER BY RaceCourse" +
    "ID";
            this.oleDbSelectCommand8.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand8
            // 
            this.oleDbInsertCommand8.CommandText = "INSERT INTO `RACE COURSE` (`RaceCourseName`, `StreetAddress`, `Suburb`, `City`, `" +
    "PhoneNumber`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand8.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RaceCourseName", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceCourseName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber")});
            // 
            // oleDbUpdateCommand8
            // 
            this.oleDbUpdateCommand8.CommandText = resources.GetString("oleDbUpdateCommand8.CommandText");
            this.oleDbUpdateCommand8.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("RaceCourseName", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceCourseName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceCourseName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceCourseName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand8
            // 
            this.oleDbDeleteCommand8.CommandText = resources.GetString("oleDbDeleteCommand8.CommandText");
            this.oleDbDeleteCommand8.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceCourseName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceCourseName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceCourseName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceCourseName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // daRaceCourse
            // 
            this.daRaceCourse.DeleteCommand = this.oleDbDeleteCommand8;
            this.daRaceCourse.InsertCommand = this.oleDbInsertCommand8;
            this.daRaceCourse.SelectCommand = this.oleDbSelectCommand8;
            this.daRaceCourse.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RACE COURSE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("RaceCourseID", "RaceCourseID"),
                        new System.Data.Common.DataColumnMapping("RaceCourseName", "RaceCourseName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber")})});
            this.daRaceCourse.UpdateCommand = this.oleDbUpdateCommand8;
            // 
            // oleDbSelectCommand9
            // 
            this.oleDbSelectCommand9.CommandText = "SELECT        [RACE ENTRY].*\r\nFROM            [RACE ENTRY]\r\nORDER BY RaceEntryID";
            this.oleDbSelectCommand9.Connection = this.ctnNZHorseRacing;
            // 
            // oleDbInsertCommand9
            // 
            this.oleDbInsertCommand9.CommandText = "INSERT INTO `RACE ENTRY` (`Status`, `RaceEntryTime`, `RaceID`, `HorseID`, `Jockey" +
    "ID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand9.Connection = this.ctnNZHorseRacing;
            this.oleDbInsertCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("RaceEntryTime", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceEntryTime"),
            new System.Data.OleDb.OleDbParameter("RaceID", System.Data.OleDb.OleDbType.Integer, 0, "RaceID"),
            new System.Data.OleDb.OleDbParameter("HorseID", System.Data.OleDb.OleDbType.Integer, 0, "HorseID"),
            new System.Data.OleDb.OleDbParameter("JockeyID", System.Data.OleDb.OleDbType.Integer, 0, "JockeyID")});
            // 
            // oleDbUpdateCommand9
            // 
            this.oleDbUpdateCommand9.CommandText = resources.GetString("oleDbUpdateCommand9.CommandText");
            this.oleDbUpdateCommand9.Connection = this.ctnNZHorseRacing;
            this.oleDbUpdateCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("RaceEntryTime", System.Data.OleDb.OleDbType.VarWChar, 0, "RaceEntryTime"),
            new System.Data.OleDb.OleDbParameter("RaceID", System.Data.OleDb.OleDbType.Integer, 0, "RaceID"),
            new System.Data.OleDb.OleDbParameter("HorseID", System.Data.OleDb.OleDbType.Integer, 0, "HorseID"),
            new System.Data.OleDb.OleDbParameter("JockeyID", System.Data.OleDb.OleDbType.Integer, 0, "JockeyID"),
            new System.Data.OleDb.OleDbParameter("Original_RaceEntryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceEntryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceEntryTime", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceEntryTime", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceEntryTime", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceEntryTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand9
            // 
            this.oleDbDeleteCommand9.CommandText = resources.GetString("oleDbDeleteCommand9.CommandText");
            this.oleDbDeleteCommand9.Connection = this.ctnNZHorseRacing;
            this.oleDbDeleteCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_RaceEntryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceEntryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceEntryTime", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceEntryTime", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceEntryTime", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceEntryTime", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_RaceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "RaceID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HorseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HorseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JockeyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JockeyID", System.Data.DataRowVersion.Original, null)});
            // 
            // daRaceEntry
            // 
            this.daRaceEntry.DeleteCommand = this.oleDbDeleteCommand9;
            this.daRaceEntry.InsertCommand = this.oleDbInsertCommand9;
            this.daRaceEntry.SelectCommand = this.oleDbSelectCommand9;
            this.daRaceEntry.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "RACE ENTRY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("RaceEntryID", "RaceEntryID"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("RaceEntryTime", "RaceEntryTime"),
                        new System.Data.Common.DataColumnMapping("RaceID", "RaceID"),
                        new System.Data.Common.DataColumnMapping("HorseID", "HorseID"),
                        new System.Data.Common.DataColumnMapping("JockeyID", "JockeyID")})});
            this.daRaceEntry.UpdateCommand = this.oleDbUpdateCommand9;
            // 
            // dsNZHorseRacing
            // 
            this.dsNZHorseRacing.DataSetName = "NZHorseRacingDataSet";
            this.dsNZHorseRacing.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datacontroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "datacontroller";
            this.Text = "datacontroller";
            ((System.ComponentModel.ISupportInitialize)(this.dsNZHorseRacing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnNZHorseRacing;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daBooking;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daCustomer;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daHorse;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daJockey;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daMeeting;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daOwner;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daRace;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
        private System.Data.OleDb.OleDbDataAdapter daRaceCourse;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
        private System.Data.OleDb.OleDbDataAdapter daRaceEntry;
        public NZHorseRacingDataSet dsNZHorseRacing;
    }
}