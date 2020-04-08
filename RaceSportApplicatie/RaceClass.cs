using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSportApplicatie
{
    public class RaceClass
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int AmountOfRace { get; set; }
        public bool Active { get; set; }

        public List<Season> Seasons { get; set; }

        public RaceClass()
        {
            Seasons = new List<Season>();
        }

        public void AddSeason(int year, string champion, int amountOfRace)
        {
            Seasons.Add(new Season()
            {
                Year = year,
                Champion = champion,
                AmountOfRace = amountOfRace
            });
        }
        public void DeleteSeason(int year)
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
