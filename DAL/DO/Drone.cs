﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DO
{
    public struct Drone
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public WeightCatagories MaxWeight { get; set; }
        public bool IsActive { get; set; }
        public override string ToString()
        {
            return $"ID: {ID}, Model: {Model},  MaxWeight: {MaxWeight}";
        }
    }
}

