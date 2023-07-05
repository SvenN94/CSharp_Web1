namespace RazorWebAppClient.Data
{
    public class Databank
    {
        public static List<Klant> Klanten { get; set; }
        public static List<Location> Locaties { get; set; }
        public static void StartDatabank()
        {
            Klanten = new List<Klant>();
            Locaties = new List<Location>();
            Klanten.Add(new Klant(1, "Klant A"));
            Klanten.Add(new Klant(2, "Klant B"));
            Locaties.Add(new Location(1, "3500", "Hasselt"));
            Locaties.Add(new Location(2, "3600", "Genk"));
        }

    }
}
