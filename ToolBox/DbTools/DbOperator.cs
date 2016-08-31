using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ToolBox.DbTools.Interfaces;

namespace ToolBox.DbTools
{
    public class DbOperator : IDbOperator
    {
        SqlConnection m_Conn;
        readonly SqlCommand m_Cmd = null;
        public void CloseConn()
        {
            if (m_Conn != null && m_Conn.State == ConnectionState.Open)
            {
                m_Conn.Close();
            }
        }

        public void DisposeCmd()
        {
            if (m_Cmd != null)
            {
                m_Cmd.Dispose();
            }
        }

        public void ExecuteMultiSql(IDbConn conn, List<IDbCmd> cmds)
        {
            using (var _conn = conn.GetConn())
            {
                _conn.Open();
                foreach (var cmd in cmds)
                {
                    using (var comd = cmd.GetCommand())
                    {
                        comd.Connection = m_Conn;
                        comd.ExecuteNonQuery();
                    }

                }
            }
        }

        public void ExecuteSql(IDbConn conn, IDbCmd cmd)
        {
            using (var _conn = conn.GetConn())
            {
                _conn.Open();
                try
                {
                    using (var _cmd = cmd.GetCommand())
                    {
                        _cmd.Connection = _conn;
                        _cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public SqlDataReader GetReader(IDbConn conn, IDbCmd cmd)
        {
            m_Conn = conn.GetConn();
            m_Conn.Open();
            try
            {
                var _cmd = cmd.GetCommand();
                _cmd.Connection = m_Conn;
                return _cmd.ExecuteReader();
            }
            catch
            {
                return null;
            }


        }
    }
}
