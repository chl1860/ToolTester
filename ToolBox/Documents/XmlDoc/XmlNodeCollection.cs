using System.Collections.Generic;
using ToolBox.Documents.XmlDoc.Interfaces;

namespace ToolBox.Documents.XmlDoc
{
    /// <summary>
    /// Cutomer node collection
    /// Add by Seven 11/1/2015
    /// </summary>
    public class XmlNodeCollection:List<IXmlNode>
    {
        public new void Add(IXmlNode node)
        {
            base.Add(node);
        }
    }
}
