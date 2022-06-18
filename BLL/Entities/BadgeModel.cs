﻿using System;

namespace BLL.Entities
{
    public class BadgeModel
    {
        public int BadgeId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Class { get; set; }
    }
}