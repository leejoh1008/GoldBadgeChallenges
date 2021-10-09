using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEightRepo
{
    public class Insurance
    {
        public string Name { get; set; }
        public int PersonId{get; set;}
        public int TimesOverSpeed { get; set; }
        public int TimesRanStopSign { get; set; }
        public int TimesRanStopLight { get; set; }
        public Insurance()
        { }

        public Insurance(string name, int personId,int timesOverSpeed, int timesRanStopSign, int timesRanStopLight)
        { 
            Name = name;
            PersonId = personId;
            TimesOverSpeed=timesOverSpeed;
            TimesRanStopSign = timesRanStopSign;
            TimesRanStopLight = timesRanStopLight;
        }
    }
}
