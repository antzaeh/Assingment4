using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class AirlineCompany
    {

        readonly string airlineName;

        SortedList<Flight, double> flights = new SortedList<Flight, double>();

        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
        }

        public string AirlineName()
        {
            return airlineName;
        }

        public Flight this[int index]
        {
            get
            {
                foreach(Flight f in flights.Keys)
                {
                    if(f.Id == index)
                    {
                        return f;
                    }
                }
                return new Flight();
            }
            set
            {
                flights.Add(value, index);
            }
        }
        public Flight GetExpensivestFlight()
        {
            return flights.Keys.Last();
        }
        public Flight GetCheapestFlight()
        {          
            return flights.Keys.First();
        }
        public string DisplayAllFlights()
        {
            StringBuilder all = new StringBuilder();

            foreach (Flight flights in flights.Keys)
            {
                all.Append(flights.ToString() + Environment.NewLine);
            }
            return all.ToString();
        }
        public Flight FindFlight(int findID)
        {
         
            foreach (var flight in flights.Keys)
            {
                if (flight.Id == findID)
                {
                    return flight;                   
                }               
            }
            return null;
        }
    }
}

