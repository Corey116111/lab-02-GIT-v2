using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Discipline
    {
        private readonly string name;
        private readonly string shortName;

        public Discipline(string name, string shortName)
        {
            this.name = name;
            this.shortName = shortName;          
        }
        public Discipline(string name, string shortName, DateTime dateHeld)
        {
            this.name = name;
            this.shortName = shortName;
        }

        public string Name
        {
            get { return name; }
        }

        public string ShortName
        {
            get { return shortName; }
        }
    }
}
