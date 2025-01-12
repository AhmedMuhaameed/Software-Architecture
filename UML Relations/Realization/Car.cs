using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Relations.Realization
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }
}
