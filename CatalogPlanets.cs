using Dz6_2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dz6_2
{
    class CatalogPlanets
    {
        private List<Planet> planets;
        public CatalogPlanets()
        {
            Planet? previousPlanet = null;
            planets = new List<Planet>
            {
                new Planet("Венера", 2, 38052, previousPlanet:previousPlanet),
                new Planet("Земля", 3, 40075, previousPlanet:previousPlanet),
                new Planet("Марс", 4, 21165, previousPlanet:previousPlanet)
            };
        }
        int i = 0;
        public (int?, int?,string?) TakePlanet(string name)
        { 
            i++;
            foreach (var planet in planets)
            {
               
                if (planet.Name == name)
                    return (planet.Number, planet.EquatorLength, null);
                
                if (i % 3 == 0)
                    return (null, null, "Вы спрашиваете слишком часто");
               
            } 
            return (null, null, "Не удалось найти планету");
        }
    }


}  
