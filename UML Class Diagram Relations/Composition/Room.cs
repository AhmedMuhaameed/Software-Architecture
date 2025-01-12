using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Architecture.UML_Relations.Composition
{
    public class Room
    {
        public string Name { get; set; }
        public Room(string name)
        {
            Name = name;
        }
    }
}
