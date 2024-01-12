using Proiect.Pages.Animale;

namespace Proiect.Models
{
    public class Proprietar
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    
        public Proprietar()
            {
                Animale = new HashSet<Animal>();
            }
        public ICollection<Animal> Animale { get; set; }
    }

}
