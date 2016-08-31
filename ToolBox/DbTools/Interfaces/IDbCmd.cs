using System.Data.SqlClient;

namespace ToolBox.DbTools.Interfaces
{
    public interface IDbCmd
    {
        SqlCommand GetCommand();
    }
}
