using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public class Film
    {
        public int filmID;
        public string filmTitle;
        public string filmGenre;
        public string filmProducer;
        public string filmActors;
        public int filmLengthInMinutes;
        public string filmCountry;
        public DateTime filmPremiere;
        public string filmMPAARating;
        public string filmCriticsRating;
        public int filmGrosses;
        public List<string> picturesPath;

        public Film (int id, string title, string genre, string producer, string actors,
                     int length, string country, DateTime premiere, string mpaaRating,
                     string criticsRating, int gross, List<string> picPath)
        {
            filmID = id;
            filmTitle = title;
            filmGenre = genre;
            filmProducer = producer;
            filmActors = actors;
            filmLengthInMinutes = length;
            filmCountry = country;
            filmPremiere = premiere;
            filmMPAARating = mpaaRating;
            filmCriticsRating = criticsRating;
            filmGrosses = gross;
            picturesPath = picPath;
        }

        public Film() { }
    }
}
