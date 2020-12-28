using Snacks.Entity.Core.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Snacks.Entity.SqlServer
{
    public class SqlServerOptions : BaseDbOptions
    {
        public SqlCredential Credential { get; set; }
    }
}
