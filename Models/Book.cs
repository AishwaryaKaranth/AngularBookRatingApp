﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTrialApp.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string BookName { get; set; }
        public int Rating { get; set; }
        public double AverageRating { get; set; }
        public string Category { get; set; }
    }
}
