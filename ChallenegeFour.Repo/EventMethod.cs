using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallenegeFour.Repo
{
    class EventMethod
    {
        List<Event> _event = new List<Event>();
        List<EventGolf> _golfEvent = new List<EventGolf>();
        List<EventBowling> _bowlingEvent = new List<EventBowling>();
        List<EventAmusement> _eventAmusement = new List<EventAmusement>();
        List<EventConcert> _concertEvent = new List<EventConcert>();
        

        public int PeopleGolf()
        {
            
            return _golfEvent.Count();
        }
    }
}
