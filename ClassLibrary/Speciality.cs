using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
<<<<<<< HEAD
    /// <summary>
    /// https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit 6 вариант
    /// </summary>
=======
>>>>>>> dev
    public class Speciality
    {
        private string name;
        private string abbreviation;
     

        public Speciality(string name, string abbreviation)
        {
            this.name = name;
            this.abbreviation = abbreviation;
          

        }

        public string Name
        {
            get { return name; }
        }

        public string Abbreviation
        {
            get { return abbreviation; }
        }
    }
}
