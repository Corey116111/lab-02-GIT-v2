
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
        private readonly string Name;
        private readonly string Surname;
        private readonly string Patronymic;
        private readonly JobTitle jobtitle;

        public Employee(string Name, string Surname, string Patronymic, JobTitle jobTitle)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.jobtitle = jobTitle;
        }

        public string Names { get { return Name; } }
        public string Surnames { get { return Surname; } }

        public string Patronymics { get { return Patronymic; } }

        public JobTitle JobTitle => jobtitle;
    }
}