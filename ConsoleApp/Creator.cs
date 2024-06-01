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
            Classroom classroom = DB.classrooms.FirstOrDefault(l => name == l.Name);
            if (classroom == null)
            {
                Employee employee = CreateEmployee();
                int countPlaces = 0;
                int countWindows = 0;
                int countEquipment = 0;
                Console.WriteLine("Введите количество посадочных мест:");
                while (!int.TryParse(Console.ReadLine(), out countPlaces) && countPlaces < 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Введите количество посадочных мест:");
                }

                Console.WriteLine("Введите количество окон:");
                while (!int.TryParse(Console.ReadLine(), out countWindows) && countWindows < 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Введите количество окон:");
                }

                Console.WriteLine("Введите количество оборудования:");

                while (!int.TryParse(Console.ReadLine(), out countEquipment) && countEquipment < 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine("Введите количество оборудования:");
                }
                Equipment[] equipment = new Equipment[countEquipment];
                for (int i = 0; i < countEquipment; i++)
                {
                    equipment[i] = CreateEquipment();
                }
              
                classroom = new Classroom(name, employee, countPlaces, countWindows, equipment);
                DB.classrooms.Add(classroom);
                Console.WriteLine("Аудитория успешно создана.");
            }
            return classroom;
        }

        public static Discipline CreateDiscipline()

        {
            Console.WriteLine("Введите название дисциплины:"); 
            string disciplineName = Console.ReadLine();

            Console.WriteLine("Введите короткое название дисциплины:");
            string disciplineShortName = Console.ReadLine();

            Discipline discipline = DB.disciplines.FirstOrDefault();

            if (discipline == null)
            {
                discipline = new Discipline(disciplineName, disciplineShortName);
                DB.disciplines.Add(discipline);
                Console.WriteLine("Дисциплина успешно создана.");
            }
            return discipline;
        }

        public static ClassLibrary.Group CreateGroup()
        {
            Console.WriteLine("Введите название группы");
            string name = Console.ReadLine();

            ClassLibrary.Group group = DB.groups.FirstOrDefault(l => name == l.Name);
            if (group == null)

            {
                Console.WriteLine("Введите сокращение группы");
                string shortname = Console.ReadLine();

                Console.WriteLine("Введите численность группы: ");
                int quantity = 0;

                while(!int.TryParse(Console.ReadLine(), out quantity) && quantity < 0)
                {
                    Console.WriteLine("Численность группы не может быть меньше нуля");
                    Console.WriteLine("Введите численность группы: ");
                }

                Console.WriteLine("Введите год поступления: ");
                int year = 0;

                while(!int.TryParse(Console.ReadLine(), out  year) && year < 0)
                {
                    Console.WriteLine("Неверный год. Повторите ввод:");
                }

                Speciality speciality = CreateSpeciality();

                Employee classroomteatcher = CreateEmployee();
                group = new ClassLibrary.Group(name, shortname, quantity, year, speciality, classroomteatcher);
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
            string FullName = $"{surname} {name} {patronymic}";
            Student student = DB.students.FirstOrDefault(l => FullName == l.FullName);

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

        public static Pair CreatePair()
        {
            TimeSpan startPair;
            TimeSpan endPair;
            TimeSpan startBreak;
            TimeSpan endBreak;

            while (true)
            {

                try
                {
                    Console.WriteLine("Введите время начала пары: ");
                    startPair = TimeSpan.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите время окончания пары: ");
                    endPair = TimeSpan.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите время начала перерыва: ");
                    startBreak = TimeSpan.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите время окончания перерыва: ");
                    endBreak = TimeSpan.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод");
                }
            }


            Shift shift = CreateShift();
            Pair pair = DB.pairs.FirstOrDefault();

            if (pair.Time_pair_start == startPair)
            {
                Console.WriteLine("В это время уже есть пара.");
            }

            if (pair == null)
            {
                pair = new Pair(startPair, endPair, startBreak, endBreak, shift);
                DB.pairs.Add(pair);
                Console.WriteLine("Пара создана.");
            }

            return pair;

        }

        static public Shift CreateShift()
        {
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();
            Shift shift = DB.shifts.FirstOrDefault();
            if (shift == null)
            {
                shift = new Shift(name);
                DB.shifts.Add(shift);
                Console.WriteLine("Смена успешно создана.");
            }

            return shift;
        }

        static public Employee CreateEmployee()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            string patronymic = Console.ReadLine();

            JobTitle jobTitle = CreateJobTitle();
            Employee employee = DB.employees.FirstOrDefault(l => jobTitle == l.JobTitle);

            if (employee == null)
            {
                employee = new Employee(name, surname, patronymic, jobTitle);
                DB.employees.Add(employee);
                Console.WriteLine("Сотрудник успешно создан");
            }

            return employee;

        }

        static public JobTitle CreateJobTitle()
        {
            Console.WriteLine("Введите название должности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите зарплату должности:");
            decimal salary = Convert.ToInt32(Console.ReadLine());

            Subdivision subdivision = CreateSubdivision();
            JobTitle jobTitle = DB.positions.FirstOrDefault(l => subdivision == l.Subdivision && name == l.Name);
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
            Console.WriteLine("Введите имя подразделения");
            string name = Console.ReadLine();
            Subdivision subdivision = DB.subdivisions.FirstOrDefault(el => el.Name == name);

            if (subdivision == null)
            {

                Employee employee = CreateEmployee();
                Organization organization = CreateOrganization();
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

        static public BuildingBody CreateBody()
        {
            Console.WriteLine("Введите название корпуса:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите адрес корпуса:");
            string address = Console.ReadLine();

            Employee employee = CreateEmployee();

            Organization organization = CreateOrganization();

            BuildingBody body = DB.buildingbodies.FirstOrDefault(l => name == l.Name && organization == l.Organization);

            if (body == null)
            {
                body = new BuildingBody(name, address, employee, organization);
                DB.buildingbodies.Add(body);
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
