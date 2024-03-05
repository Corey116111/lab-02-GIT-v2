using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Lesson
    {
        private string date;
        private Discipline discipline;
        private Employee employee;
        private Classroom classroom;
        private Group group;
        private Pair pair;
        private Body body; /// 14 варианта у нас нет, поэтому ссылаюсь на 13

        public Lesson(string date, Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair, Body body)
        {
            this.date = DateTime.Today.ToString();
            this.discipline = discipline;
            this.employee = employee;
            this.classroom = classroom;
            this.group = group;
            this.pair = pair;
            this.body = body;
        }
    }
}
