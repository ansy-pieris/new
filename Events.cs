using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Events
    {
        private int eventID;
        private string eventName;
        private DateTime dateTime;
        private int maxParticipants;
        private int currentParticipants;
        private string venue;
        private string location;
        private string description;
        private string startTime;
        private string endTime;

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public int MaximumParticipants
        {
            get { return maxParticipants; }
            set { maxParticipants = value; }
        }
        public int CurrentParticipants
        {
            get { return currentParticipants; }
            set { currentParticipants = value; }
        }
        public string Venue
        {
            get { return venue; }
            set { venue = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
       
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public Events(int eventID, string eventName, DateTime dateTime, int maximumParticipants, int currentParticipants ,string venue, string location, string description, string startTime, string endTime)
        {
            this.eventID = eventID;
            this.eventName = eventName;
            this.dateTime = dateTime;
            this.maxParticipants = maximumParticipants;
            this.currentParticipants = currentParticipants;
            this.venue = venue;
            this.location = location;
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
