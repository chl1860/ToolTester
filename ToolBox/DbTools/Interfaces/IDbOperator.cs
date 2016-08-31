using System.Collections.Generic;
using System.Data.SqlClient;

namespace ToolBox.DbTools.Interfaces
{
    public interface IDbOperator
    {
        void CloseConn();
        void DisposeCmd();
        void ExecuteSql(IDbConn conn,IDbCmd cmd);
        void ExecuteMultiSql(IDbConn conn, List<IDbCmd> cmds);
        SqlDataReader GetReader(IDbConn conn, IDbCmd cmd);
    }
}
