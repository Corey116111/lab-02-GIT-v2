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
    public class Job_title
    {
        private string name;
        private int salary;
        private Subdivision subdivision;


        public Job_title(string name, int salary, Subdivision subdivision)
        {
            this.name = name;
            this.salary = salary;
            this.subdivision = subdivision;
        }

    }
}
