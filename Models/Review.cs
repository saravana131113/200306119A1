using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _200306119A1.Models
{
    public class Review
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Reviews { get; set; }
        public int NumberofStars { get; set; }
        public int ReviewID { get; set; }
    }
}