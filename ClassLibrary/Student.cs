using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Student
    {
        private string surname;
        private string name;
        private string patronymic;
        private Group group;
<<<<<<< Updated upstream
        private string birth;
        public Student(string surname, string name, string patronymic, Group group, string birth)
=======
        private DateTime birth;

        public Student(string surname, string name, string patronymic, Group group, DateTime birth)
>>>>>>> Stashed changes
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
                this.birth = DateTime.Today;
            }
        }
<<<<<<< Updated upstream
=======

        public string Surname
        {
            get { return surname; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Patronymic
        {
            get { return patronymic; }
        }
        public Group Group
        {
            get { return group; }
        }
         public DateTime Birth
        {
            get { return birth; }
        }
>>>>>>> Stashed changes
    }
}
