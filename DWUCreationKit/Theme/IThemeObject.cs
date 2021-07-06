using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWCreationKit.DWTheme
{
    interface IThemeObject
    {
        string Name { get; set; }
        string GUID { get; }
        int IncrementalID { get; }
    }
}
