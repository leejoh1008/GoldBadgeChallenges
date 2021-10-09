using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEightRepo
{
    public class InsuranceMethods
    {
        private double five = 5.00;
        private double ten = 10.00;
        private double two = 2.00;

        List<Insurance> _people = new List<Insurance>();   //create
        public bool AddInsurance(Insurance peep)
        {
            if(peep is null)
            { return false; }
            _people.Add(peep);
            return true;
        }
        public List<Insurance> GetList()
        {
            return _people;
        }
        public bool RemoveInsurance(int ids)
        {
            Insurance peep = GetPeep(ids);
            if (peep == null)
            {
                return false;
            }
            int initialCount = _people.Count;
            _people.Remove(peep);

            if (initialCount > _people.Count)
            {
                return true;
            }
            else { return false; }
        }   
        
        private Insurance GetPeep(int id)
        {
            foreach (Insurance person in _people)
            {
                if (person.PersonId == id)
                {
                    return person;
                }

            }
            return null;
        }
    }
}
