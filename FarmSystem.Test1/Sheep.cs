﻿using System;

namespace FarmSystem.Test
{
    public class Sheep : Animal
    {
       
        private string _id;
        private int _noOfLegs;

        public Sheep()
        {
            base.name = "Sheep";
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
            Console.WriteLine("Sheep says baa!");
        }
        
        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }

    }

}