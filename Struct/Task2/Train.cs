using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    struct Train:IComparable
    {
        public int numberOfTrain;
        public DateTime departureTime;
        public string nameOfDestinationStation;

        public Train(string nameOfDestinationStation, int numberOfTrain, DateTime departureTime)
        {
            this.departureTime = departureTime;
            this.numberOfTrain = numberOfTrain;
            this.nameOfDestinationStation = nameOfDestinationStation;
        }

        public void Show()
        {
            Console.WriteLine("{0} | {1} | {2}|", departureTime, nameOfDestinationStation, numberOfTrain);
        }
        public int CompareTo(object obj)
        {
            Train train = (Train)obj;
            return this.numberOfTrain.CompareTo(train.numberOfTrain);
        }
    }
}
