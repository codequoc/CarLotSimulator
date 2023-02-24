using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
            numberOfCars++;
        }
        public List<Car> cars = new List<Car>();

        public static int numberOfCars { get; set; }
    }
}
