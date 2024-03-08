// https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Employee
    {
        private string UserName;
        private string UserSurname;
        private string UserPatronymic;
        private Job_title job_title;

        public Employee(string UserName, string UserSurname, string UserPatronymic, Job_title job_Title)
        {
            this.UserName = UserName;
            this.UserSurname = UserSurname;
            this.UserPatronymic = UserPatronymic;
            this.job_title = job_Title;
        }
    }
}
