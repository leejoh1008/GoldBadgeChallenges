using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallenegeFour.Repo
{
    public class Event
    {
        public int NumberOfPeople { get; set; }
        public string TypeOfEvent { get; set; }  
        public DateTime DateOfEvent { get; set; }
        public int CostPerPerson { get; set; }

        public Event() { }
        public Event(int numberOfPeople, string typeOfEvent, DateTime dateOfEvent, int costPerPerson, bool eventGolf, bool eventBowling, bool eventAmusement, bool eventConcert)
        {
            NumberOfPeople = numberOfPeople;
            TypeOfEvent = typeOfEvent;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
        }
    }
    public class EventGolf :Event
    { }
    public class EventBowling : Event
    { }
    public class EventAmusement : Event
    { }
    public class EventConcert : Event
    { }
   
}
  