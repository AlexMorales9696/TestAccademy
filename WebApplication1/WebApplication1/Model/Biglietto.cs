namespace WebApplication1.Model
{
    public class Biglietto
    {
        public int IdBiglietto { get; set; }
        public string Posto { get; set; }
        public Decimal Prezzo  { get; set; }
        public int IdSalaCinematograficaB{ get; set; }
        public int Sconto { get; set; }
    }
}
