using System;
using System.Collections.Generic;

namespace FarmSystem.Test
{

    public class EmydexFarmSystem
    {
        public List<Animal> noOfAnimals = new List<Animal>();
        Animal newAnimal;
        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            newAnimal = animal;
            noOfAnimals.Add(newAnimal);

            Console.WriteLine(newAnimal.name + " has entered the Emydex farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (noOfAnimals.Count == 0)
                Console.WriteLine("There are no animals in the farm");
            else
            {
                for (int i = 0; i < noOfAnimals.Count; i++)
                    noOfAnimals[i].Talk();
            }
        }

        //TEST 3 
        public void MilkAnimals()
        {
            for (int i = 0;i < noOfAnimals.Count; i++)
            {
                if (noOfAnimals[i] is IMilkableAnimal)
                    noOfAnimals[i].ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach(Animal animal in noOfAnimals)
            {
                Console.WriteLine(animal.name + " has left the farm");
            }
            noOfAnimals.Clear();
            if (noOfAnimals.Count == 0)
                Console.WriteLine("Emydex farm is now empty");
        }
    }
}