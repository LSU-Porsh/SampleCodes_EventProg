using System;
using System.Windows.Forms;

namespace Midterm_EventMngmt
{
    public partial class EventView : Form
    {

        public string EventName;
        public string EventDescription;
        public string EventLocation;
        public string ContactPerson;
        public int ContactNumber;
        public string EventStartDate;
        public string EventStartTime;
        public string EventEndDate;
        public string EventEndTime;
        public int eventid;
        EventData ReadData = new EventData();






        public EventView()
        {
            InitializeComponent();
        }


        private void EventView_Load(object sender, EventArgs e)
        {

            // view.Columns.Add("Event_ID", typeof(int));
            //view.Columns.Add("Event_Title", typeof(string));
            //view.Columns.Add("Event_Description", typeof(string));
            //view.Columns.Add("Event_Location", typeof(string));
            //view.Columns.Add("Contact_Person", typeof(string));
            //view.Columns.Add("Contact_Number", typeof(int));
            //view.Columns.Add("EventStartDate", typeof(string));
            //view.Columns.Add("EventStartTime", typeof(string));
            //view.Columns.Add("EventEndDate", typeof(string));
            //view.Columns.Add("EventEndTime", typeof(string));

            EventDetailsView.DataSource = ReadData.globalData;

        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {


        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            ReadData.AddData();
        }
    }
}
