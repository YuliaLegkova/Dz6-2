namespace Dz6_2
{
    class CatalogPlanets
    {
        
       
        private readonly List<Planet> planets;
        private static int callCounter = 0;
        public CatalogPlanets()
        {

            planets = new List<Planet>();
            var venus = new Planet("Венера", 2, 38052, null);
            var earth = new Planet("Земля", 3, 40075, venus);
            var mars = new Planet("Марс", 4, 21165, earth);
            planets.Add(venus);
            planets.Add(earth);
            planets.Add(mars);
            
            
        }
         public (int? Number, int? EquatorLength, string? ErrorMessage) GetPlanet(string name)
        {

            callCounter++;
            foreach (var planet in planets)
            {
                if (planet.Name == name)
                {
                    
                    if (callCounter % 3 == 0)
                    {
                        callCounter = 0;
                        return (null, null, "Вы спрашиваете слишком часто");
                    }
                    return (planet.Number, planet.EquatorLength, null);
                }     
                
            }
            if (callCounter % 3 == 0)
            {
                callCounter = 0;
                return (null, null, "Вы спрашиваете слишком часто");
            }
            return (null, null, "Не удалось найти планету");
        }
    }
}  
