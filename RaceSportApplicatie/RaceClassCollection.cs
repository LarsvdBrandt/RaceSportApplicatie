using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSportApplicatie
{
    public class RaceClassCollection
    {

        public List<RaceClass> RaceClasses { get; set; }
        public RaceClassCollection()
        {
            RaceClasses = new List<RaceClass>();
        }
        public void AddRaceClass(string name, int year, int amountOfRace, bool active)
        {
            RaceClasses.Add(new RaceClass()
            {
                Name = name,
                Year = year,
                AmountOfRace = amountOfRace,
                Active = active
            });
        }
        public void UpdateRaceClass(string className, string name, int year, int amountOfRace, bool active)
        {
            foreach (var item in RaceClasses)
            {
                if (item.Name == className)
                {
                    RaceClasses.Remove(item);
                    AddRaceClass(name, year, amountOfRace, active);
                    return;
                }
            }
        }
        public void DeleteRaceClass(string name)
        {
            foreach (var item in RaceClasses)
            {
                if (item.Name == name)
                {
                    RaceClasses.Remove(item);
                    return;
                }
            }
        }
    }
}
