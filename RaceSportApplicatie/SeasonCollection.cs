using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSportApplicatie
{
    public class SeasonCollection
    {
        public List<Season> Seasons { get; set; }
        public SeasonCollection()
        {
            Seasons = new List<Season>();
        }

        public void AddSeason(string champion, int amountOfRace, int year)
        {
            Seasons.Add(new Season()
            {
                Champion = champion,
                AmountOfRace = amountOfRace,
                Year = year
            });
        }
        public void UpdateSeason(int classYear, string champion, int amountOfRace, int year)
        {
            foreach (var item in Seasons)
            {
                if (item.Year == classYear)
                {
                    Seasons.Remove(item);
                    AddSeason(champion, amountOfRace, year);
                    return;
                }
            }
        }
        public void DeleteRaceTeam(int year)
        {
            foreach (var item in Seasons)
            {
                if (item.Year == year)
                {
                    Seasons.Remove(item);
                    return;
                }
            }
        }
    }
}
