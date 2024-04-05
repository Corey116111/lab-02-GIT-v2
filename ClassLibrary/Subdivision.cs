using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1XUtn0QpVUQmailvo24lJ3XjJT5NP0SPjzi_vPOF1N9A/edit 11 вариант
    /// </summary>
    public class Subdivision
    {
        private readonly string name;
        private readonly Employee director;
        private readonly Organization organization;
        private readonly DateTime dateFoundation;

        public Subdivision(string name, Employee director, Organization organization, DateTime date)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
            dateFoundation = date;
        }

        public string Name
        {
            get { return name; }
        }
        public string DateFoundation
        {
            get { return dateFoundation.ToString(); }
        }

        public Employee Employe => director;

        public Organization Organization => organization;
    }
}
