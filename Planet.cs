namespace Dz6_2
{
    internal class Planet(string name, int number, int equatorLength, Planet? previousPlanet)

    {
        public string Name { get; } = name;
        public int Number { get; } = number;
        public int EquatorLength { get; } = equatorLength;
        public Planet? PreviousPlanet { get; } = previousPlanet;
    }

}

