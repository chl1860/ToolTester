using System.Data.SqlClient;

namespace ToolBox.DbTools.Interfaces
{
    public interface IDbConn
    {
        SqlConnection GetConn();
    }
}
