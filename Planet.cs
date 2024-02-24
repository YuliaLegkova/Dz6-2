using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Dz6_2
{
    class Planet(string name, int number, int equatorLength, Planet? previousPlanet)


    {
        public string Name { get; } = name;
        public int Number { get; } = number;
        public int EquatorLength { get; } = equatorLength;
        public Planet? PreviousPlanet { get; } = previousPlanet;
    }

}
