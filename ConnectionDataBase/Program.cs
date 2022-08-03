using System.Data.Common;

namespace ConnectionDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var databasConnections = new List<DbConnection>();
            databasConnections.Add(new SqlConnection());
            databasConnections.Add(new OracleConnection());
            
            var implementChanges = new Implementation();
            implementChanges.DatabaseServer(databasConnections);

            DbConnection _initAccessSqlConnection = new SqlConnection();
        }
    }

}