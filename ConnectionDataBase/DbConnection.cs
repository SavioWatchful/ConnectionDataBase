using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConnectionDataBase
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection()
        {
            ConnectionString: ;
            Timeout: CloseConnectionPt();
        }
        public override void OpenConnectionPt()
        {
            DateTime _initAccess = DateTime.Now;
            string _openSuccess = ConnectionString;
            string _openFailure = ConnectionString.Substring();
        }

        public override void CloseConnectionPt()
        {
            throw new NotImplementedException();
            string _closeSuccess = ConnectionString;
            string _closeFailiure = CloseConnectionPt(NotImplementedException);
        }
    }

    public class OracleConnection: DbConnection
    {
        public override void OpenConnectionPt()
        {
            throw new NotImplementedException();
        }

        public override void CloseConnectionPt()
        {
            return ConnectionString;
        }
    }
}
