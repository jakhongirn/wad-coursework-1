﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccess.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public Category EventCategory { get; set; }
    }
}
