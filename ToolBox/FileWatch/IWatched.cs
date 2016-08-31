using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.FileWatch
{
    public interface IWatched
    {
        Delegate GetDeleagete();
    }
}
