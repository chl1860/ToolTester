using System.Collections.Generic;
using System.Text;

namespace ToolTester
{
    class PiiTemplateDbModel
    {
        private readonly string m_TbName;
        private readonly List<DbFields> m_Flist = new List<DbFields>();
        public PiiTemplateDbModel(string dbTable)
        {
            m_TbName = dbTable;
        }

        public void SetFileds(string fieldsName, string fieldsVal)
        {
            m_Flist.Add(new DbFields
            {
                FiledsName = fieldsName,
                FiledsVal = fieldsVal
            });
        }

        public string GetInserSql()
        {
            var sbSql = new StringBuilder();

            sbSql.Append("INSERT INTO ")
                .Append(m_TbName)
                .Append("(");

            for (var i = 0; i < m_Flist.Count; i++)
            {
                sbSql.Append(m_Flist[i].FiledsName);
                sbSql.Append(i != m_Flist.Count - 1 ? "," : ") Values(");
            }

            //Add field value
            for (var i = 0; i < m_Flist.Count; i++)
            {
                sbSql.Append("'" + m_Flist[i].FiledsVal + "'");
                sbSql.Append(i != m_Flist.Count - 1 ? "," : ")");
            }

            return sbSql.ToString();
        }
    }

    class DbFields
    {
        public string FiledsName { get; set; }
        public string FiledsVal { get; set; }
    }
}
