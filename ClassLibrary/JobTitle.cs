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
    internal class JobTitle
    {
        private string name;
        private int salary;
        private Subdivision subdivision;


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

    }
}
