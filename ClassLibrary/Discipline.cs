using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit 3 вариант
    /// </summary>
    public class Discipline
    {
        private string name;
        private string shortName;
        public Discipline(string name, string shortName)
        {
            this.name = name; this.shortName = shortName;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
