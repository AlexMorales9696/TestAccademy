namespace WebApplication1.Model
{
    public class Film
    {
        public int IdFilm { get; set; }
        public string Autore { get; set; }
        public string  Produttore{ get; set; }
        public string Genere { get; set; }
        public decimal Durata { get; set; }
        public DateTime OrarioFilm { get; set; }
    }
}
