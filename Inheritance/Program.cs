using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var blueJay = new Bird();
            blueJay.Age = 5;
            blueJay.Name = "Blue Bird";
            blueJay.Height = 15;
            blueJay.Weight = 2;
            blueJay.WingSpan = 10;
            blueJay.Migratory = true;
            blueJay.FeatherColor = "Blue";
            blueJay.BeakColor = "Black";

            Console.WriteLine("Info about My Bird");

            var birdProperties = TypeDescriptor.GetProperties(blueJay.GetType());
            foreach (PropertyDescriptor property in birdProperties)
            {
                var value = property.GetValue(blueJay);
                var prop = property.Name;
                Console.WriteLine(prop + ": " + value);
            }


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptile();
            alligator.Age = 10;
            alligator.Name = "The Hungry Alligator";
            alligator.Height = 10;
            alligator.Weight = 100;
            alligator.Shell = false;
            alligator.Scales = true;
            alligator.Legs = true;
            alligator.SkinColor = "Green";

            Console.WriteLine("");
            Console.WriteLine("Info about My Reptile");

            var repProperties = TypeDescriptor.GetProperties(alligator.GetType());
            foreach (PropertyDescriptor property in repProperties)
            {
                var value = property.GetValue(alligator);
                var prop = property.Name;
                Console.WriteLine(prop + ": " + value);
            }

        }
    }
}
