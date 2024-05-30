using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{ 
    /// <summary>
    /// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit 4 вариант
    /// </summary>
 
    public class Group
    {
        private readonly string name;
        private readonly string shortname;
        private readonly int quantity;
        private readonly int year;
        private readonly Speciality speciality;
        private readonly Employee classroomteatcher;

        public Group(string name, string shortname, int quantity, int year, Speciality speciality, Employee classroomteatcher)
        {
            this.name = name;
            this.shortname = shortname;
            this.quantity = quantity;
            this.year = year;
            this.speciality = speciality;
            this.classroomteatcher = classroomteatcher;
        }
        public string Name
        {
            get { return name; }
        }

        public string Shortname
        {
            get { return shortname; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public int Year
        {
            get { return year; }
        }

        public Speciality Speciality
        {
            get { return speciality; }
        }

        public Employee Classroomteatcher
        {
            get { return classroomteatcher; }
        }
    }
}
