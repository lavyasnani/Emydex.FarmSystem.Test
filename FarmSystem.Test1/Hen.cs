using System;

namespace FarmSystem.Test
{
    public class Hen : Animal
    {
        private string _id;
        private int _noOfLegs = 2;

        public Hen()
        {
            base.name = "Hen";
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
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}