using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSportApplicatie
{
    public class Season
    {
        public string Champion { get; set; }
        public int AmountOfRace { get; set; }
        public int Year { get; set; }

        public List<RaceTeam> RaceTeams { get; set; }

        public Season()
        {
            RaceTeams = new List<RaceTeam>();
        }

        public void AddTeam(string name, string mainSponsor, string city, string country, int year)
        {
            RaceTeams.Add(new RaceTeam()
            {
                Name = name,
                MainSponsor = mainSponsor,
                City = city,
                Country = country,
                Year = year
            });
        }
        public void DeleteTeam(string name)
        {
            foreach (var item in RaceTeams)
            {
                if(item.Name == name)
                {
                    RaceTeams.Remove(item);
                    return;
               }
            }
        }
    }
}
