
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit 9 вариант
    /// </summary>
    public class Employee
    {
        private readonly string name;
        private readonly string surname;
        private readonly string patronymic;
        private readonly JobTitle jobtitle;

        public Employee(string name, string surname, string patronymic, JobTitle jobTitle)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.jobtitle = jobTitle;
        }
        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public string Patronymic { get { return patronymic; } }

        public JobTitle JobTitle => jobtitle;
    }
}