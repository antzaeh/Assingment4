using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Flight : IComparable<Flight>
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Flight(int id, string origin, string destination, DateTime date, double price)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
            Price = price;
        }

        public Flight()
        {

        }

        public override string ToString()
        {
            string formattedDate = Date.ToString("MM/dd/yyyy");
            return $"Flight ID: {Id}, Origin: {Origin}, Destination: {Destination}, Date: {formattedDate}, Price: {Price}";
        }

        public int CompareTo(Flight other)
        {
            if (other == null)
            {
                return -1;

            }
            if (this.Price < other.Price)
            {
                return -1;

            }
            else if (this.Price > other.Price)
            {
                return 1;

            }
            else
            {
                return 0; 
            }
        }
    }
}

