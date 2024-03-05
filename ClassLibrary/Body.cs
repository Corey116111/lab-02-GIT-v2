using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Body
    {
        private string name;
        private string address;
        private string TheCommandant;
        private Student student;
        private Organization organization;
        public Body(string name, string address, string TheCommandant, Student student, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.TheCommandant = TheCommandant;
            this.student = student;
            this.organization = organization;
        }
    }
}
