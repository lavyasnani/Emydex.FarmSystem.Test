﻿using System;

namespace FarmSystem.Test
{
    public class Horse : Animal
    {
        private string _id;
        private int _noOfLegs;

        public Horse()
        {
            base.name = "Horse";
        }
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }
        

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}