using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSportApplicatie
{
    public class RaceTeamCollection
    {

        public List<RaceTeam> RaceTeams { get; set; }

        public RaceTeamCollection()
        {
            RaceTeams = new List<RaceTeam>();
        }
        public void AddRaceTeam (string name, string mainSponsor, string city, string country, int year)
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
        public void UpdateRaceTeam(string className, string name, string mainSponsor, string city, string country, int year)
        {
            foreach (var item in RaceTeams)
            {
                if (item.Name == className)
                {
                    RaceTeams.Remove(item);
                    AddRaceTeam(name, mainSponsor, city, country, year);
                    return;
                }
            }
        }
        public void DeleteRaceTeam(string name)
        {
            foreach (var item in RaceTeams)
            {
                if (item.Name == name)
                {
                    RaceTeams.Remove(item);
                    return;
                }
            }
        }
    }
}
