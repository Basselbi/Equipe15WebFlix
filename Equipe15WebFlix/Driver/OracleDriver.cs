using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Driver;
using Oracle.ManagedDataAccess.Client;

namespace Equipe15WebFlix.Driver
{
    public class OracleDriver : DriverBase
    {
        public override IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }
        public override IDbConnection CreateConnection()
        {
            return new OracleConnection();
        }
        public override string NamedPrefix
        {
            get { return string.Empty; }
        }
        public override bool UseNamedPrefixInParameter
        {
            get { return false; }
        }
        public override bool UseNamedPrefixInSql
        {
            get { return false; }
        }
    }
}
