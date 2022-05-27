namespace WebApplication1.Model
{
    public class Spettatore
    {
        public int IdSpettatore { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public int Sconto { get; set; }

        public int IdBigliettoS { get; set; }
    }

}
