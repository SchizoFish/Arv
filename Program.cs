using Arv.Animals;
using System;
using System.Collections.Generic;

namespace Arv
{
    class Program
    {
        // Listor
        static List<Animal> animals = new List<Animal>();
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
            // Instansierar djur och lägger till i Animal listan
            Dog dog = new Dog("Sparky", 5, 6, "Brown", "Weiner dog");
            animals.Add(dog);
            Bird bird = new Bird("Sparrow", 2, 1, "Black", 2);
            animals.Add(bird);
            Worm worm = new Worm("Earth Worm", 1, 0.002, "Brown", "Dirt");
            animals.Add(worm);
            Swan swan = new Swan("Hans", 3, 5, "White", 2, true);
            animals.Add(swan);
            Horse horse = new Horse("Maximus", 5, 426, "Black", 50);
            animals.Add(swan);
            Wolf wolf = new Wolf("Lady", 5, 35, "Grey", true);
            animals.Add(wolf);
            Dog dog2 = new Dog("Jack", 8, 22, "Orange & White", "Duck Tolling Retriever");
            animals.Add(dog2);

            // Lägger till tidigare instansierade hunder i Dog listan
            dogs.Add(dog);
            dogs.Add(dog2);


            // F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Eftersom listan är av typen Dog, och Horse inte ärver från Dog kan en häst
            // inte läggas till i listan (ej heller kan den typecastas till en Dog)
            // dogs.Add(horse);


            // F:Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // Som med den första listan går alla djur att läggas tillsammans i en Animal lista
            // då de alla ärver av klassen Animal


            // F: Förklara vad det är som händer.
            // För varje Animal som finns i listan anropar loopen Stats() metoden från
            // underklassens (Dog, Bird, etc.), och exekverar den. Underklassens Stats
            // körs eftersom de är overrides, så de skriver över basklass-metoden
            foreach (Animal animal in animals)
            {
                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    person.Talk();
                }
                Console.WriteLine(animal.Stats());
                Console.Write("Makes sound: ");
                animal.DoSound();
                Console.WriteLine();
            }


            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine();

                    // F: Kommer du åt metoden från Animals listan? Varför inte?
                    // Eftersom listtypen är Animal, och Animal varken har en BarkThreeTimes metod
                    // eller ärver från en basklass som har den metoden, så kan den inte anropas
                    // Console.WriteLine(animal.BarkTreeTimes()); < funkar inte

                    // för att fixa detta kan vi göra som med IPerson i tidigare foreach
                    // och typecasta animal till Dog
                    Dog dogToBark = (Dog)animal;
                    Console.WriteLine(dogToBark.BarkThreeTimes());
                    Console.WriteLine();
                }
            }

        }
    }
}
