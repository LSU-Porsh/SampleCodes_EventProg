using System.Windows.Forms;

namespace Midterm_EventMngmt
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
        }

        private void AddEventBtn_Click(object sender, System.EventArgs e)
        {

            EventName = EventTitleTB.Text;
            EventDescription = EventDesTB.Text;
            EventLocation = LocationCB.Text;
            ContactPerson = ContPerTB.Text;
            ContactNumber = int.Parse(ContNoTB.Text);
            EventStartDate = EventStartDatePicker.Text;
            EventStartTime = EventStartTimePicker.Text;
            EventEndDate = EventEndDatePicker.Text;
            EventEndTime = EventEndTimePicker.Text;

            EventData newData = new EventData(EventName, EventDescription, EventLocation, ContactPerson,
               ContactNumber, EventStartDate, EventStartTime, EventEndDate, EventEndTime);

            newData.AddData();


            EventView eventlist = new EventView();
            eventlist.ShowDialog();
            this.Close();
        }


    }



}
