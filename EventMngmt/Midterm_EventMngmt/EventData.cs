using System.Data;

namespace Midterm_EventMngmt
{
    public class EventData
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
        public int eventID;

        public DataTable globalData = new DataTable();


        public EventData(string EventName, string EventDescription,
            string EventLocation, string ContactPerson,
            int ContactNumber, string EventStartDate,
            string EventStartTime, string EventEndDate,
            string EventEndTime)
        {

            //globalData.Columns.Add("Event_ID", typeof(int));
            globalData.Columns.Add("Event Title", typeof(string));
            globalData.Columns.Add("Event_Description", typeof(string));
            globalData.Columns.Add("Event_Location", typeof(string));
            globalData.Columns.Add("Contact_Person", typeof(string));
            globalData.Columns.Add("Contact_Number", typeof(int));
            globalData.Columns.Add("EventStartDate", typeof(string));
            globalData.Columns.Add("EventStartTime", typeof(string));
            globalData.Columns.Add("EventEndDate", typeof(string));
            globalData.Columns.Add("EventEndTime", typeof(string));

            this.EventName = EventName;
            this.EventDescription = EventDescription;
            this.EventLocation = EventLocation;
            this.ContactPerson = ContactPerson;
            this.ContactNumber = ContactNumber;
            this.EventStartDate = EventStartDate;
            this.EventStartTime = EventStartTime;
            this.EventEndDate = EventEndDate;
            this.EventEndTime = EventEndTime;
            eventID++;

            globalData.Rows.Add(EventName,
               EventDescription, EventLocation,
               ContactPerson, ContactNumber,
               EventStartDate, EventStartTime,
               EventEndDate, EventEndTime);
        }

        public EventData()
        {

        }


        public void AddData()
        {


            //DataRow newRow = globalData.NewRow();
            //newRow[0] = this.EventName;
            //newRow[1] = this.EventDescription;
            //newRow[2] = this.EventLocation;
            //newRow[3] = this.ContactPerson;
            //newRow[4] = this.ContactNumber;
            //newRow[5] = this.EventStartDate;
            //newRow[6] = this.EventStartTime;
            //newRow[7] = this.EventEndDate;
            //newRow[8] = this.EventEndTime;


            //globalData.Rows.Add(newRow);


        }




    }
}
