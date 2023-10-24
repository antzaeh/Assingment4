using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new DateTime(2001, 11, 11).ToString("yyy/mm/dd"));

            AirlineCompany company = new AirlineCompany("Winnair");

            company[0] = new Flight(1, "Vaasa", "Hese", new DateTime(2001, 1, 1), 73.00);
            company[1] = new Flight(2, "Hese", "Viro", new DateTime(2022, 2, 2), 69.00);
            company[2] = new Flight(3, "Viro", "Vaasa", new DateTime(2033, 3, 3), 420.00);
            company[3] = new Flight(4, "Hesa", "Ruotsi", new DateTime(2044, 4, 4), 666.00);
            company[4] = new Flight(5, "Tampere", "Sjoki", new DateTime(2055, 5, 5), 42.00);
            //Console.WriteLine("123");
            Console.WriteLine(company[4]);

            Console.WriteLine("All Flights sorted by price: \n"+ company.DisplayAllFlights());
            

               Console.WriteLine("Cheapest flight");
               Flight cheapestFlight = company.GetCheapestFlight();
               Console.WriteLine("AirlineCompany: " + company.AirlineName() +" "+ cheapestFlight.ToString());

               Console.WriteLine("Most expensive flight");
               Flight expensivestFlight = company.GetExpensivestFlight();
               Console.WriteLine(expensivestFlight.ToString());

               Console.Write("Enter ID: ");
               int findID = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"You wanted to find flights with id: {findID}");
               Console.WriteLine(company.FindFlight(findID));
        }
    }
}