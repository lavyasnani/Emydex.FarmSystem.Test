using System;

namespace FarmSystem.Test
{
    public class Cow : Animal, IMilkableAnimal
    {
        private string _id;
        private int _noOfLegs = 4;

        public Cow()
        {
            base.name = "Cow";
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
            Console.WriteLine("Cow says Moo!");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public override void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}