using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit 5 вариант
    /// </summary>
    public class Student
    {
        private string surname;
        private string name;
        private string patronymic;
        private Group group;
        private string birth;
        public Student(string surname, string name, string patronymic, Group group, string birth)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            if (birth != null)
            {
                this.birth = birth;
            }
            else
            {
                this.birth = DateTime.Today.ToString();
            }
        }
    }
}
