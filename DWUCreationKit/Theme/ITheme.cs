using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWCreationKit.DWTheme
{
    interface ITheme
    {
        string Name { get; set; }
        string GUID { get; set; }
        int Version { get; set; }
        int SubVersion { get; set; }
    }
}
