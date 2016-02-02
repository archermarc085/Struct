using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numberOfTrain = 11;
            Train t1 = new Train("New York", 11, DateTime.Parse("5/1/2008 8:30:52 AM", System.Globalization.CultureInfo.InvariantCulture));
            t1.Show();
            Train[] train = new Train[8];
            char j = 'A';

            for (int i = 0; i < train.GetLength(0); i++)
            {
                train[i].numberOfTrain = rand.Next(0, 100);
                train[i].departureTime = DateTime.Now;
                train[i].nameOfDestinationStation = j.ToString();
                j++;
            }

            List<Train> trains = new List<Train>(train);
            trains.Add(t1);
            trains.Sort();
            Console.WriteLine("Find trains:");
            foreach (var item in trains)
            {
                if (item.numberOfTrain == numberOfTrain)
                {
                    Console.WriteLine(item.nameOfDestinationStation);
                    Console.WriteLine(item.numberOfTrain);
                    Console.WriteLine(item.departureTime);
                }
                else
                {
                    Console.WriteLine("No trains!");
                }

            }
            Console.ReadLine();
        }
    }
}
