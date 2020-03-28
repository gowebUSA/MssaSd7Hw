using System;

namespace AnimalSound
{
    class AnimalSound
    {
        /*
         *******Makes the computer language more easier and nicer to read for human.******
         * 
         * 
        public static void AnimalSounds(string animal = "duck", string sound = "quack")
        {

            Console.WriteLine($"The {animal} goes \"{sound}\"!");
            AnimalSounds();
            Console.ReadLine();

        }
        */

        /*
        // Calls the two-parameter method with a default sound
        public void AnimalSound(string animal)
        {
            AnimalSound(animal, "quack");
        }

        // Calls the one-parameter method with a default animal
        // OR
        // Calls the two-parameter method with a default animal and sound
        public void AnimalSound()
        {
            AnimalSound("duck");
            // OR
            // AnimalSound("duck", "quack");
        }
        */


        static string duckSound(string animal, string sound)
            {
                return animal + sound;
            }
        static string dogSound(string animal, string sound)
        {
            return animal + sound;
        }
        static void Main(string[] args)
        {
            string duck = duckSound("duck", " quack");
            string dog = duckSound("dog", " woof");

            Console.WriteLine($"The {duck}");
            Console.WriteLine($"The {dog}");
            Console.WriteLine("AnimalSound.Program.Main()");
            //ref: www.w3schools.com/cs/showjava.asp?filename=demo_method_overloading
        }

        //static void Main(string[] args)
        //{
        //    string animal = "duck";
        //    string sound = "quack";

        //    Console.WriteLine($"The {animal} goes \"{sound}\"!");
        //    Console.WriteLine("AnimalSound.Program.Main()");
        //}
    }
}
