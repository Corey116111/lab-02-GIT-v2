using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit
    /// 10 variant
    /// </summary>
    public class JobTitle
    {
        private readonly string name;
        private readonly int salary;
        private readonly Subdivision subdivision;


        public JobTitle(string name, int salary, Subdivision subdivision)
        {
            this.name = name;
            this.salary = salary;
            this.subdivision = subdivision;
        }

        public string Name
        {
            get { return name;  }
        }

        public int Salary
        {
            get { return salary; }
        }

        public Subdivision Subdivision { get { return subdivision; } }

    }
}
