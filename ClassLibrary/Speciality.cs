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
        private string date;

        public Speciality(string name, string abbreviation, string date)
        {
            this.name = name;
            this.abbreviation = abbreviation;
            this.date = DateTime.Today.ToString();

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
