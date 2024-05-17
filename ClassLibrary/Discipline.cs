using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
<<<<<<< HEAD
    /// <summary>
    /// https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit 3 вариант
    /// </summary>
=======
>>>>>>> dev
    public class Discipline
    {
        private string name;
        private string shortName;
        private DateTime dateHeld;

        public Discipline(string name, string shortName)
        {
            this.name = name;
            this.shortName = shortName;
            this.dateHeld = DateTime.Now;
        }
        public Discipline(string name, string shortName, DateTime dateHeld)
        {
            this.name = name;
            this.shortName = shortName;
            this.dateHeld = dateHeld;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
