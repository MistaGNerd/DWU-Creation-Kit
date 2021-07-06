using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWCreationKit.DWTheme
{
    public class Theme : ITheme
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GUID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Version { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SubVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<ThemeObject> ThemeObjectCollection = new List<ThemeObject>();
    }
}
