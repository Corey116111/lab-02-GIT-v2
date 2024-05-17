using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Subdivision
    {
        private string name;
        private Employee director;
        private Organization organization;
        private DateTime dateFoundation;


        public Subdivision(string name, Employee director, Organization organization)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
            dateFoundation = DateTime.Now;
        }
        public Subdivision(string name, Employee director, Organization organization, DateTime date)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
            dateFoundation = date;
        }

        public string Name => name;
        public string DateFoundation => dateFoundation.ToString();
        public Employee Employee => director;
        public Organization Organization => organization;


    }
}
