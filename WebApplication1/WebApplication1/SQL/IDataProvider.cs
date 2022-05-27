using WebApplication1.Model;

namespace WebApplication1.SQL
{
    public interface IDataProvider
    {
        public void  Add(Spettatore spettatore);
        public bool CheckPosti(SalaCinematografica sala);
        public void MesaagioP();
        public IEnumerable<SalaCinematografica> SaleCinematograficheByIdCinema(int idCinema);
        public IEnumerable<Film> GetFilms();
    }
}
