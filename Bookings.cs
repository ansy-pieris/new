using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMGTNew
{
    internal class Bookings
    {
        private int bookingID;
        private int eventID;
        private Events Events;
        private int participantID;
        private Participant Participant;
        private DateTime dateTime;

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public Events Eventsdetails
        {
            get { return Events; }
            set { Events = value; }
        }
        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }
        public Participant Participantdetails
        {
            get { return Participant; }
            set { Participant = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public Bookings(int bookingID,int eventID, Events Events, int participantID, Participant Participants,DateTime dateTime)
        {
            this.bookingID = bookingID;
            this.eventID = eventID;
            this.Events = Events;
            this.participantID = participantID;
            this.Participant = Participants;
            this.dateTime = dateTime;
        }
    }
}
