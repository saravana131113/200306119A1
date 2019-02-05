using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _200306119A1.Models
{
    public class game
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumRequirement { get; set; }
        public int PublisherID { get; set; }
        public string DeveloperID { get; set; }
        public string GenreID { get; set; }
        public string ReviewID { get; set; }
        public int GameID { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Developer Developer { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Review Review { get; set; }
    }
}