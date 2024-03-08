using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Discipline
    {
        private string name;
        private string shortName;
        public Discipline(string name, string shortName)
        {
            this.name = name; this.shortName = shortName;
        }
    }
}
