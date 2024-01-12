namespace Proiect.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Specie { get; set; }
        public string Rasa { get; set; }
        public int Varsta { get; set; }

        public int? ProprietarID { get; set; } 
        public Proprietar? Proprietar { get; set; }



    }

}
