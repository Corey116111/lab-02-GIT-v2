﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary
<<<<<<< HEAD
{   /// <summary>
    /// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit?pli=1 13 вариант
    /// </summary>
=======
{
>>>>>>> dev
    public class Body
    {
        private readonly string name;
        private readonly string address;
        private readonly Employee employee;
        private readonly Organization organization;

        public Body(string name, string address, Employee employee, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.employee = employee; 
            this.organization = organization; 
        }

        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public Employee Employe => employee;
        public Organization Organization => organization;
    }
}