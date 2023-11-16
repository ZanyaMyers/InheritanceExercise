using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common - done 


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class -done 

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile -done
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Bird crow = new Bird();
            crow.CanFly = true;
            crow.WingSpan = 2;
            crow.Color = "black"; 
            crow.NumberOfLegs = 2;

            Reptile lizard = new Reptile();
            lizard.HasScales = true;
            lizard.IsColdBlooded = true;
            lizard.Color = "green";
            lizard.NumberOfLegs = 4;

            crow.PrintBirdDetails(); 
            lizard.PrintReptileDetails();

        }
    }
}
