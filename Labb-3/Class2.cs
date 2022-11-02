﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses_Labb3
{
    public class Booking
    {
        public string Name { get; set; }
        public int TableNumber { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public Booking(string name, int tablenNumber, DateTime datetime, string time)
        {
            Name = name;
            TableNumber = tablenNumber;
            Date = datetime;
            Time = time;
        }
        public string ListBookings()
        {
            string output = Date + ", " + Name + ", " + TableNumber + Time;
            return output;
        }
    }
}