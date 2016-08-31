using System.IO;
using System.Text;
using System.Xml;
using ToolBox.Documents.XmlDoc.Interfaces;

namespace ToolBox.Documents.XmlDoc
{
    public class XmlSimpleOperater:IXmlOperater
    {
        private readonly XmlDocument m_XmlDoc;
        private readonly string m_FileName;

        public XmlSimpleOperater(string fileName)
        {

            m_FileName = fileName;
            m_XmlDoc = new XmlDocument();
        }

        public void Create(string rootName,XmlNodeCollection collection)
        {
            //var dic = new Dictionary<string, string>();
            var xmlTextWriter = new XmlTextWriter(m_FileName, Encoding.Default);

            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement(rootName);

            foreach (var item in collection)
            {
                xmlTextWriter.WriteStartElement(item.NodeName);
                xmlTextWriter.WriteString(item.NodeValue);
                xmlTextWriter.WriteEndElement();
            }
            xmlTextWriter.Close();
        }

        public bool AppendNode(string rootName, IXmlNode node)
        {
            if (File.Exists(m_FileName))
            {
                m_XmlDoc.Load(m_FileName);
                var root = m_XmlDoc.SelectSingleNode(rootName); //查找根节点
                var child = m_XmlDoc.CreateElement(node.NodeName);
                child.InnerText = node.NodeValue;

                if (root != null)
                {
                    root.AppendChild(child);
                }
                return true;
            }
            return false;
        }

        public bool RemoveNode(string rootName, IXmlNode node)
        {
            if (File.Exists(m_FileName))
            {
                m_XmlDoc.Load(m_FileName);
                var root = m_XmlDoc.SelectSingleNode(rootName);
                var child = GetChildNodeByName(root, node.NodeName);

                if (child != null)
                {
                    if (root != null) root.RemoveChild(child);
                }
                return true;
            }
            return false;
        }

        public string GetNodeValue(string rootName, string nodeName)
        {
            string nodeVal = string.Empty;

            if (File.Exists(m_FileName))
            {
                m_XmlDoc.Load(m_FileName);
                var root = m_XmlDoc.SelectSingleNode(rootName);
                var child = GetChildNodeByName(root, nodeName);

                if (child != null)
                {
                    nodeVal = child.InnerText;
                }
            }
            return nodeVal;
        }

        public void UpdateNode(string rootName, IXmlNode node)
        {
            if (File.Exists(m_FileName))
            {
                m_XmlDoc.Load(m_FileName);
                var root = m_XmlDoc.SelectSingleNode(rootName);
                var child = GetChildNodeByName(root, node.NodeName);
                if (child != null)
                {
                    child.InnerText = node.NodeValue;
                }
            }

        }

        /// <summary>
        /// Update Node from collection:{nodeName,nodeValue}
        /// </summary>
        public void UpdateNode(string rootName, XmlNodeCollection collection)
        {
            if (File.Exists(m_FileName))
            {
                m_XmlDoc.Load(m_FileName);
                var root = m_XmlDoc.SelectSingleNode(rootName);

                if (collection.Count > 0)
                {
                    foreach (var item in collection)
                    {
                        var child = GetChildNodeByName(root, item.NodeName);
                        if (child != null)
                        {
                            child.InnerText = item.NodeValue;
                        }
                    }
                }
            }
        }

        public void Save()
        {
            m_XmlDoc.Save(m_FileName);

        }

        private XmlNode GetChildNodeByName(XmlNode root, string childNodeName)
        {
            XmlNode node = null;

            if (root != null)
            {
                foreach (XmlNode child in root.ChildNodes)
                {
                    if (child.Name == childNodeName)
                    {
                        node = child;
                    }
                }

            }
            return node;
        }

    }
}
