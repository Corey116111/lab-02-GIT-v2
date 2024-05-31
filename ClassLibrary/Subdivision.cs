using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11 вариант https://docs.google.com/document/d/1XUtn0QpVUQmailvo24lJ3XjJT5NP0SPjzi_vPOF1N9A/edit
namespace ClassLibrary
{
    public class Subdivision
    {
        private readonly string name;
        private readonly Employee director;
        private readonly Organization organization;



        public Subdivision(string name, Employee director, Organization organization)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
        }


        public string Name => name;
        public Employee Employee => director;
        public Organization Organization => organization;


    }
}
