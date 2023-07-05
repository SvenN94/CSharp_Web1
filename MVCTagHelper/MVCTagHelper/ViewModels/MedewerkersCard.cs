using MVCTagHelper.Data;
using MVCTagHelper.Models;

namespace MVCTagHelper.ViewModels
{
    public class MedewerkersCard
    {
        public MedewerkersCard(TagHelperDbContext context,Medewerker medewerker)
        {
            // _context = context
            MedewerkerId = medewerker.MedewerkerId;
            AfdelingNaam = medewerker.Afdeling.AfdelingNaam;
            MedewerkerNaam = $"{medewerker.Naam} + {medewerker.VoorNaam}";
            Medewerker = medewerker;
            

        }
        public Medewerker Medewerker { get; set; }
        public int MedewerkerId { get; set; }
        public string MedewerkerNaam { get; set; }
        public string AfdelingNaam { get; set; }
       
    }
}
