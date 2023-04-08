//Grading ID: S0941
//CIS 199-02
//Program 4
//Due: (4/18/21)
//This assignment creates a repair record for a auto repair company. Uses 2 classes, methods and arrays. Includes example data set and updated data set.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        //Method that accepts the array below
        public static void OutputRepairRecords(RepairRecord[] RepairRecords)
        {
            foreach (var RepairRecord in RepairRecords) //for every object in the array
            {
                Console.WriteLine(RepairRecord.ToString()); //^calls the to string method to print object in the array
                Console.WriteLine("Calculated Cost Output: $" + RepairRecord.calcCost()); //prints calculated cost at the end of each data set object in the array
            }
        }
        static void Main(string[] args)
        {
            //Decalres new array with 6 objects to store data for the repair record
            RepairRecord[] RepairRecords = new RepairRecord[6];
            //Example Array. Example data for first invoke.
            RepairRecords[0] = new RepairRecord(41051, 2011, "Ford F150", "C493768459", 45, "Bob Jones", false);
            RepairRecords[1] = new RepairRecord(40203, 2005, "Toyota Matrix", "C857395785", 60, "Monica Fitzgerald", true);
            RepairRecords[2] = new RepairRecord(40202, 2019, "Tesla Model 3", "C583953958", 15, "Bob Jones", false);
            RepairRecords[3] = new RepairRecord(40208, 2020, "Mclaren F1", "C968486749", 120, "Mike Lewis", true);
            RepairRecords[4] = new RepairRecord(40212, 2500, "Gallifreyan Tardis", "C968857575", 150, "The Doctor", true);
            RepairRecords[5] = new RepairRecord(40211, 3600, "Correllian Tie Fighter", "C565756555", 80, "Luke Skywalker", false);
            OutputRepairRecords(RepairRecords);  //Invokes OutputRepairRecords to display example data in correct format

            //Updated Array. Example data but with new zipcodes.
            RepairRecords[0] = new RepairRecord(51051, 2011, "Ford F150", "C493768459", 45, "Bob Jones", false);
            RepairRecords[1] = new RepairRecord(50203, 2005, "Toyota Matrix", "C857395785", 60, "Monica Fitzgerald", true);
            RepairRecords[2] = new RepairRecord(50202, 2019, "Tesla Model 3", "C583953958", 15, "Bob Jones", false);
            RepairRecords[3] = new RepairRecord(50208, 2020, "Mclaren F1", "C968486749", 120, "Mike Lewis", true);
            RepairRecords[4] = new RepairRecord(50212, 2500, "Gallifreyan Tardis", "C968857575", 150, "The Doctor", true);
            RepairRecords[5] = new RepairRecord(50211, 3600, "Correllian Tie Fighter", "C565756555", 80, "Luke Skywalker", false);
            Console.WriteLine("\nUpdated Data (changed zip codes):"); //Writes that updated data is being printed
            OutputRepairRecords(RepairRecords); //Invokes OutputRepairRecords to display new data in correct format (changed zipcodes)
        }
    }
}
