using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Relations.Dependency
{
    public class Car
    {
        public void StartCar()
        {
            Engine engine = new Engine();
            engine.Start();
        }
    }
}
