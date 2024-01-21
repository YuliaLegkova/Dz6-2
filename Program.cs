namespace Dz6_2
{
    internal class Program
    {
              static void Main()
            {
                CatalogPlanets catalog = new CatalogPlanets();

                Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: "  + catalog.TakePlanet("Земля"));
                Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Лимония"));
                Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Марс"));   
                Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Венера"));
                Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Земля")); 
                Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Земля"));
                Console.WriteLine("Лимония имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Лимония"));
                Console.WriteLine("Марс имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Марс"));
                Console.WriteLine("Земля имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Земля"));
                Console.WriteLine("Венера имеет порядковый номер от Солнца и длину экватора: " + catalog.TakePlanet("Венера"));
        }
    }
}
