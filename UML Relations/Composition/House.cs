using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Relations.Composition
{
    public class House
    {
        public List<Room> Rooms { get; }

        public House()
        {
            Rooms = new List<Room> { new Room("Living Room"), new Room("Bedroom") };
        }


    }
}
