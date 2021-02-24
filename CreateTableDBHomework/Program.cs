using CreateTableDBHomework.Data;

namespace CreateTableDBHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var gruppaDataAccess = new GruppaDataAccess();
            gruppaDataAccess.CreateTable();
        }
    }
}
