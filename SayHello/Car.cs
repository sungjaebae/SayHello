﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BusinessLogic
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLiscense { get; set; }

    }
    public class Car
    {
        public double Speed { get; set; }
        public Color Color { get; set; }
        public Human Driver { get; set; }
    }
}
