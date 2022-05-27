using WebApplication1.Model;

namespace WebApplication1.SQL
{
    public interface IDataProvider
    {
        public void  Add(Spettatore spettatore);
        public bool CheckPosti(SalaCinematografica sala);
        public void MesaagioP();
    }
}
