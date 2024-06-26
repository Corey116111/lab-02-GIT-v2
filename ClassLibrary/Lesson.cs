﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit 1 вариант
    /// </summary>
    public class Lesson
    {
        private readonly DateTime dateHeld;
        private readonly Discipline discipline;
        private readonly Employee employee;
        private readonly Classroom classroom;
        private readonly Group group;
        private readonly Pair pair;
        private readonly TypeOfActivity lessonType;
        
        public Lesson(DateTime dateHeld, Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair, TypeOfActivity lessonType)
        {
            this.dateHeld = dateHeld;
            this.discipline = discipline;
            this.employee = employee;
            this.classroom = classroom;
            this.group = group;
            this.pair = pair;
            this.lessonType = lessonType;
        }

        public Lesson(Discipline discipline, Employee employee, Classroom classroom, Group group, Pair pair, TypeOfActivity lessonType)
            : this(DateTime.Now, discipline, employee, classroom, group, pair, lessonType)
        {

        }

        public DateTime DateHeld => dateHeld;
        public Discipline Discipline => discipline;
        public Employee Employe => employee;
        public Classroom Classroom => classroom;
        public Group Group => group;
        public Pair Pair => pair;
        public TypeOfActivity TypeOfActivity => lessonType;
    }
}