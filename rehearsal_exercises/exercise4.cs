using System;
using System.Collections.Generic;

namespace rehearsal_exercises

{
    public class Flights
    {
        public List<FlightPaths> flightPaths;
        public Flights()
        {
            this.flightPaths = new List<FlightPaths>();
        }
        public void AddConnection(string departure, string destination, int price)
        {
            this.flightPaths.Add(new FlightPaths(departure, destination, price));
        }

        public int RoutePrice(string departure, string destination)
        {
            //Settings up the price array
            int[] price = new int[this.flightPaths.Count + 1];
            int[] indexArray = new int[this.flightPaths.Count + 1]

            for (int i = 0; i < price.Length; i++)
            {
                price[i] = int.MaxValue;
            }

            int indexOfDeparture = 0;
            for(int i = 0; i < this.flightPaths.Count; i++)
            {
                if (this.flightPaths[i].departure == departure)
                {
                    indexOfDeparture = i;
                    break;
                }
                else
                {
                    price[indexOfDeparture] = 0;
                }
            }



            while(true)
            {
                bool change = false;

                foreach (FlightPaths flight in this.flightPaths)
                {
                    if (price[flight.departure] != int.MaxValue && (price[fli]))
                }
            }


            return indexOfDeparture;
        }
    }
    public class FlightPaths
    {
        public string departure;
        public string destination;
        public int price;
        public FlightPaths(string departure, string destination, int price)
        {

            this.departure = departure;
            this.destination = departure;
            this.price = price;
        }
    }
}