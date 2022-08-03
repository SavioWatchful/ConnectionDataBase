using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDataBase
{
    public class Implementation
    {
        public Implementation()
        {
        }
        public void DatabaseServer(List<DbConnection> databasConnections)
        {
            foreach (var db in databasConnections)
            {
                if (String.IsNullOrWhiteSpace(db.ConnectionString))
                {
                    throw new Exception("Empty, null or whitespace value not valid.");
                }
                else
                {
                    databasConnections()
                    
                }
            }
        }
    }
}
