namespace MVCTagHelper.Models
{
    public class Medewerker
    {
        public int MedewerkerId { get; set; }
        public Afdeling Afdeling { get; set; }
        public string Naam { get; set; }
        public string VoorNaam { get; set; }
        public string Email { get; set; }
    }
}
