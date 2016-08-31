using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.LocalPCTools
{
    public interface ICommandModule
    {
        string IpAddress { get; }
        string SubnetMask { get; }
        string GateWay { get; }
    }
}
