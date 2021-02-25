using CreateTableDBHomework.Data;

namespace CreateTableDBHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var gruppaDataAccess = new GruppaDataAccess())
            {
                gruppaDataAccess.CreateTable();
            }
        }
    }
}
