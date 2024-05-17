using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
<<<<<<< HEAD
    /// <summary>
    /// https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit 12 вариант
    /// </summary>
=======
>>>>>>> dev
    public class Organization
    {
        private string name;
        private string legalAdress;
        private string actualAdress;
        private Employee employee;
        public Organization(string name, string legalAdress, string actualAdress, string refSupervisor, Employee employee)
        {
            this.name = name;
            this.legalAdress = legalAdress;
            this.actualAdress = actualAdress;
            this.employee = employee;

        }

        public string Name
        {
            get { return name; }
        }
    }

}
