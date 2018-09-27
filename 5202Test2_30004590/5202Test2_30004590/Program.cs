using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Ryan Webb
 * Date: 27/09/2018
 * Program Title: Bird Manager
 * Program Description: This program stores information on new birds from the Wingspan National Bird of Prey Centre
 * in Paradise Valley, Rotorua. This program starts off with all data sets defualted to be "unkown", meaning the program
 * is ready for new information. Any user is propmpted to update the programe with new bird information. The program 
 * then displays all information stored.
 * 
 * */

namespace _5202Test2_30004590
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Intialising Variables
            string name = "unknown", species = "unknown", sex = "unknown", weight = "unknown", bandNo = "unknown";
            BIRD bird1 = new BIRD(name, species, sex, weight, bandNo );

            //Prompts for user Inputs
            Console.WriteLine("\nPLEASE UPDATE BIRD DATA");
            Console.Write("Enter Bird name:");
            bird1.Name = Console.ReadLine();
            Console.Write("Enter Species:");
            bird1.Species = Console.ReadLine();
            Console.Write("Enter Sex of Bird:");
            bird1.Sex = Console.ReadLine();
            Console.Write("Enter Weight of Bird:");
            bird1.Weight = Console.ReadLine();
            Console.Write("Enter Band Number of Bird:");
            bird1.BandNo = Console.ReadLine();

            //Calling DisplayBird Method 
            Console.WriteLine(bird1.DisplayBird());

            Console.WriteLine("\nEnter to Continue");
            Console.ReadLine();
        }
    }

    class BIRD
    {


        //Public Getters and Setters
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public string BandNo { get; set; }

        //Public Constructor
        public BIRD(string _name, string _species, string _sex, string _weight, string _bandNo)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            BandNo = _bandNo;

            Console.WriteLine("Bird Object Created And Default Data Loaded...");
        }

        //Public Data Display Method
        public string DisplayBird()
        {
            return "\n************************" + "\nBIRD OF PREY DATA OUTPUT" + "\nBird Name: " + Name +"\nSpecies: "+ Species 
                +"\nSex: "+Sex+ "\nWeight: "+Weight+ "\nBandNumber"+BandNo + "\n************************";
            
        }

    }



}
