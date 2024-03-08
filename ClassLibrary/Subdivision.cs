using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Subdivision
    {
        private string name;
        private Employee director;
        private Organization organization;
        public Subdivision(string name, Employee director, Organization organization)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
        }
    }
}
