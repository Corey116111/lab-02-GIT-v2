﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Creator
    {
        
        public static Lesson CreateLesson()
        {
            Discipline discipline = CreateDiscipline();

            Employee employee = CreateEmployee();

            Classroom classroom = CreateClassroom();

            Console.WriteLine("Введите начало пары (в формате чч:мм):");
            string pairStart = Console.ReadLine();

            while (!ValidateTimeFormat(pairStart))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairStart = Console.ReadLine();
            }

            Console.WriteLine("Введите конец пары (в формате чч:мм):");
            string pairEnd = Console.ReadLine();

            while (!ValidateTimeFormat(pairEnd))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairEnd = Console.ReadLine();
            }


            Pair pair = CreatePair();

            ClassLibrary.Group group = CreateGroup();

            Console.WriteLine("Введите дату:");
            string date = Console.ReadLine();

            TypeOfActivity typeOfActivity = CreateTypeOfActivity();

            Lesson lesson = DB.lessons.FirstOrDefault(l => discipline == l.Discipline && employee == l.Employe && classroom == l.Classroom && pair == l.Pair && group == l.Group && typeOfActivity == l.TypeOfActivity);

            if (lesson == null)
            {
                lesson = new Lesson(DateTime.Parse(date), discipline, employee, classroom, group, pair, typeOfActivity);
                DB.lessons.Add(lesson);
                Console.WriteLine("Занятие успешно создано.");
            }

            return lesson;
        }
      
        public static Classroom CreateClassroom()
        {
            return null;
        }
        
        public static Discipline CreateDiscipline()
        {
            return null;
        }

        public static ClassLibrary.Group CreateGroup()
        {
            return null;
        }

        public static Student CreateStudent()
        {
            return null;
        }
        
        public static Speciality CreateSpeciality()
        {
            return null;
        } 

        public static Pair CreatePair()
        {
            return null;
        }
        
        static public Shift CreateShift()
        {
            return null;
        }

        static public Employee CreateEmployee()
        {
            return null;
        }

        static public JobTitle CreateJobTitle() // на будущее
        {
            return null;
        }

        static public Subdivision CreateSubdivision()
        {
            return null;
        }

        static public Organization CreateOrganization()
        {
            return null;
        }

        static public Body CreateBody()
        {
            return null;
        }
        static public TypeOfActivity CreateTypeOfActivity()
        {
            return null;
        } 

         private static bool ValidateTimeFormat(string time)
         {
            string pattern = @"^(2[0-3]|[01][0-9]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
         }

    }
}