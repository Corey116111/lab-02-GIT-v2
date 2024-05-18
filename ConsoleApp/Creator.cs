using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Console.WriteLine("Введите название аудитории:");
            string name = Console.ReadLine();

            Employee employee = CreateEmployee();

            Console.WriteLine("Введите количество посадочных мест:");
            bool f1 = int.TryParse(Console.ReadLine(), out int countPlaces);
            while (countPlaces < 0 || !f1)
            {
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine("Введите количество посадочных мест:");
                f1 = int.TryParse(Console.ReadLine(), out countPlaces);
            }

            Console.WriteLine("Введите количество окон:");
            bool f2 = int.TryParse(Console.ReadLine(), out int countWindows);
            while (countWindows < 0 || !f2)
            {
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine("Введите количество окон:");
                f2 = int.TryParse(Console.ReadLine(), out countWindows);
            }

            Console.WriteLine("Введите количество оборудования:");
            bool f3 = int.TryParse(Console.ReadLine(), out int countEquipment);
            while (countEquipment < 0 || !f3)
            {
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine("Введите количество оборудования:");
                f3 = int.TryParse(Console.ReadLine(), out countEquipment);
            }
            Equipment[] equipment = new Equipment[countEquipment];
            for(int i = 0; i < countEquipment; i++)
            {
                equipment[i] = CreateEquipment();
            }

            Classroom classroom = DB.classrooms.FirstOrDefault(l => name == l.Name && employee == l.Employee && countPlaces == l.Places && countWindows == l.Windows && equipment == l.Equipment);

            if (classroom == null)
            {
                classroom = new Classroom(name, employee, countPlaces, countWindows, equipment);
                DB.classrooms.Add(classroom);
                Console.WriteLine("Аудитория успешно создана.");
            }

            return classroom;
        }
        
        public static Discipline CreateDiscipline() // тимлид делать за людей не будет
        {
            return null;
        }

        public static ClassLibrary.Group CreateGroup()
        {
            Console.WriteLine("Введите название группы");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращение группы");
            string shortname = Console.ReadLine();

            Console.WriteLine("Введите численность группы");
            int quantity = int.Parse(Console.ReadLine());

            if(quantity <= 0) 
            {
                Console.WriteLine("Численность группы не может быть меньше нуля");
                quantity = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите год поступления");
            int year = int.Parse(Console.ReadLine());

            if(year <= 0)
            {
                Console.WriteLine("Неверный год. Повторите ввод:");
                year = int.Parse(Console.ReadLine());
            }

            Speciality speciality = CreateSpeciality();

            Employee classroomteatcher = CreateEmployee();

            ClassLibrary.Group group = DB.groups.FirstOrDefault(l => speciality == l.Speciality && classroomteatcher == l.Classroomteatcher);
            if (group == null)
            {
                group = new ClassLibrary.Group(name, shortname, quantity, speciality, classroomteatcher, year);
                DB.groups.Add(group);
                Console.WriteLine("Группа успешно создана.");
            }

            return group;
        }

        public static Student CreateStudent() 
        {
            Console.WriteLine("Введите фамилию студента:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите отчество студента:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите день рождения студента:");
            string birth = Console.ReadLine();

            ClassLibrary.Group group = CreateGroup();

            Student student = DB.students.FirstOrDefault(l => group == l.Group);

            if (student == null)
            {
                student = new Student(surname, name, patronymic, group, DateTime.Parse(birth));
                DB.students.Add(student);
                Console.WriteLine("Студент успешно создан");
            }

            return student;
        }

        public static Speciality CreateSpeciality()
        {
            Console.WriteLine("Введите название специальности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название специальности:");
            string abbreviation = Console.ReadLine();

            Speciality speciality = DB.specialties.FirstOrDefault();
            if (speciality == null)
            {
                speciality = new Speciality(name, abbreviation);
                DB.specialties.Add(speciality);
                Console.WriteLine("Специальность успешно создана.");
            }
            return speciality;
        }

        public static Pair CreatePair() // тимлид делать за людей не будет
        {
            return null;
        }
        
        static public Shift CreateShift()
        {
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();
            Shift shift = new Shift(name);
            if (shift == null)
            {
                DB.shifts.Add(shift);
                shift = new Shift(name);
                Console.WriteLine("Смена успешно создана.");
            }

            return shift;
        }

        static public Employee CreateEmployee() // тимлид делать за людей не будет
        {
            return null;
        }

        static public JobTitle CreateJobTitle() 
        {
            Console.WriteLine("Введите название должности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите зарплату должности:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Subdivision subdivision = CreateSubdivision();
            JobTitle jobTitle = DB.positions.FirstOrDefault(l => subdivision == l.Subdivision);
            if (jobTitle == null)
            {
                jobTitle = new JobTitle(name, salary, subdivision);
                DB.positions.Add(jobTitle);
                Console.WriteLine("Должность успешно создана.");
            }
            return jobTitle;

        }

        static public Subdivision CreateSubdivision()
        {
            Employee employee = CreateEmployee();
            Organization organization = CreateOrganization();
            Console.WriteLine("Введите имя подразделения");
            string name = Console.ReadLine();
            Subdivision subdivision = DB.subdivisions.FirstOrDefault(el => el.Employee == employee && el.Organization == organization);

            if (subdivision == null)
            {
                subdivision = new Subdivision(name, employee, organization);
                DB.subdivisions.Add(subdivision);
                Console.WriteLine("подразделение успешно создано.");
            }
            return subdivision;
        }

        static public Organization CreateOrganization() // тимлид делать за людей не будет
        { 
            return null;
        }

        static public Body CreateBody()
        {
            Console.WriteLine("Введите название корпуса:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите адрес корпуса:");
            string address = Console.ReadLine();

            Employee employee = CreateEmployee();

            Organization organization = CreateOrganization();

            Body body = DB.bodies.FirstOrDefault(l => employee == l.Employe && organization == l.Organization);

            if (body == null)
            {
                body = new Body(name, address, employee, organization);
                DB.bodies.Add(body);
                Console.WriteLine("Корпус успешно создан.");
            }

            return body;
        }
        static public TypeOfActivity CreateTypeOfActivity()
        {
            Console.WriteLine("Введите название вида занятия:");
            string name = Console.ReadLine().ToUpper();

            TypeOfActivity typeOfActivity = DB.TypesOfActivity.FirstOrDefault();

            if (typeOfActivity == null)
            {
                typeOfActivity = new TypeOfActivity(name);
                DB.TypesOfActivity.Add(typeOfActivity);
                Console.WriteLine("Вид занятия успешно создан.");
            }

            return typeOfActivity;
        }

        public static Equipment CreateEquipment()//Заглушка. Отсутствующий вариант
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
