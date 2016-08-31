namespace ToolBox.Documents.XmlDoc.Interfaces
{
    public interface IXmlOperater
    {
        void Create(string rootName, XmlNodeCollection collection);
        bool AppendNode(string rootName, IXmlNode node);
        bool RemoveNode(string rootName, IXmlNode node);
        string GetNodeValue(string rootName, string nodeName);
        void UpdateNode(string rootName, IXmlNode node);
        void UpdateNode(string rootName, XmlNodeCollection collection);
        void Save();
    }
}
