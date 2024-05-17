using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Printer
    {
        public static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine("Урок:");
            Console.WriteLine($"Дата: {lesson.DateHeld}");
            PrintDiscipline(lesson.Discipline);
            PrintEmployee(lesson.Employe);
            PrintClassroom(lesson.Classroom);
            PrintGroup(lesson.Group);
            PrintPair(lesson.Pair);
            PrintTypeOfActivity(lesson.TypeOfActivity);
        }

        public static void PrintDiscipline(Discipline discipline) 
        {
            Console.WriteLine("Дисциплина:");
            Console.WriteLine($"Название: {discipline.Name}");
            Console.WriteLine($"Краткое название: {discipline.ShortName}");
        }
        
        public static void PrintClassroom(Classroom classroom)
        {
            Console.WriteLine("Аудитория:");
            Console.WriteLine($"Номер: {classroom.Number}");
            Console.WriteLine($"Ответственный сотрудник: {classroom.Employee.Name} {classroom.Employee.Surname} {classroom.Employee.Patronymic}");
            Console.WriteLine($"Количество мест: {classroom.Places}");
            Console.WriteLine($"Количество окон: {classroom.Windows}");
            Console.WriteLine($"Оборудование: {string.Join<Equipment>(", ", classroom.Equipment)}");
        }

        public static void PrintGroup(Group group)
        {
            Console.WriteLine("Группа:");
            Console.WriteLine($"Название: {group.Name}");
            Console.WriteLine($"Краткое название: {group.Shortname}");
            Console.WriteLine($"Количество студентов: {group.Quantity}");
            Console.WriteLine($"Год создания: {group.Year}");
            PrintSpeciality(group.Speciality);
            PrintEmployee(group.Classroomteatcher);
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine("Студент:");
            Console.WriteLine($"Фамилия: {student.Surname}");
            Console.WriteLine($"Имя: {student.Name}");
            Console.WriteLine($"Отчество: {student.Patronymic}");
            Console.WriteLine($"Группа: {student.Group.Name}");
            Console.WriteLine($"Дата рождения: {student.Birth:dd.MM.yyyy}");
        }

        public static void PrintSpeciality(Speciality speciality)
        {
            Console.WriteLine("Специальность:");
            Console.WriteLine($"Название: {speciality.Name}");
            Console.WriteLine($"Аббревиатура: {speciality.Abbreviation}");
        }

        public static void PrintPair(Pair pair) // good
        {
            Console.WriteLine("Пара:");
            Console.WriteLine($"Начало: {pair.Time_pair_start}");
            Console.WriteLine($"Конец: {pair.Time_pair_end}");
            Console.WriteLine($"Начало перерыва: {pair.Time_break_start}");
            Console.WriteLine($"Конец перерыва: {pair.Time_break_end}");
            Console.WriteLine($"Смена: {pair.Shift.Name}");
        }

        public static void PrintShift(Shift shift) // good
        {
            Console.WriteLine("Смена:");
            Console.WriteLine($"Название: {shift.Name}");
        }
        
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Сотрудник:");
            Console.WriteLine($"Имя: {employee.Name}");
            Console.WriteLine($"Фамилия: {employee.Surname}");
            Console.WriteLine($"Отчество: {employee.Patronymic}");
            Console.WriteLine($"Должность: {employee.JobTitle.Name}");
        }

        public static void PrintJobTitle(JobTitle jobTitle) // good
        {
            Console.WriteLine("Должность:");
            Console.WriteLine($"Название: {jobTitle.Name}");
            Console.WriteLine($"Зарплата: {jobTitle.Salary}");
            Console.WriteLine($"Подразделение: {jobTitle.Subdivision.Name}");
        }

        public static void PrintSubdivision(Subdivision subdivision)
        {
            Console.WriteLine("Подразделение:");
            Console.WriteLine($"Название: {subdivision.Name}");
            PrintEmployee(subdivision.Employee);
            PrintOrganization(subdivision.Organization);
        }

        public static void PrintOrganization(Organization organization)
        {
            Console.WriteLine("Организация:");
            Console.WriteLine($"Название: {organization.Name}");
            Console.WriteLine($"Юридический адрес: {organization.LegalAdress}");
            Console.WriteLine($"Фактический адрес: {organization.ActualAdress}");
            if (organization != null && organization.Employee != null)
            {
                Console.WriteLine($"Руководитель:  {organization.Employee.Surname} {organization.Employee.Name} {organization.Employee.Patronymic}");
            }
        }

        public static void PrintBody(Body body)
        {
            Console.WriteLine("Корпус:");
            Console.WriteLine($"Название: {body.Name}");
            Console.WriteLine($"Адрес: {body.Address}");
            if (body.Employee != null)
            {
                Console.WriteLine($"Ответственный сотрудник: {body.Employee.Name} {body.Employee.Surname} {body.Employee.Patronymic}");
            }
            else
            {
                Console.WriteLine("Комендант не указан");
            }
            Console.WriteLine($"Организация: {body.Organization.Name}");
        }
        
        public static void PrintTypeOfActivity(TypeOfActivity typeofactivity) // good
        {
            Console.WriteLine("Вид деятельности:");
            Console.WriteLine($"Буква: {typeofactivity.Letter}");
        }
        
        public static void PrintObjectsList(int choice)
        {
            switch (choice)
            {
                case 1:
                    foreach (var body in DB.bodies)
                    {
                        PrintBody(body);
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    foreach (var classroom in DB.classrooms)
                    {
                        PrintClassroom(classroom);
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    foreach (var discipline in DB.disciplines)
                    {
                        PrintDiscipline(discipline);
                        Console.WriteLine();
                    }
                    break;
                case 4:
                    foreach (var group in DB.groups)
                    {
                        PrintGroup(group);
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    foreach (var student in DB.students)
                    {
                        PrintStudent(student);
                        Console.WriteLine();
                    }
                    break;
                case 6:
                    foreach (var speciality in DB.specialties)
                    {
                        PrintSpeciality(speciality);
                        Console.WriteLine();
                    }
                    break;
                case 7:
                    foreach (var pair in DB.pairs)
                    {
                        PrintPair(pair);
                        Console.WriteLine();
                    }
                    break;
                case 8:
                    foreach (var shift in DB.shifts)
                    {
                        PrintShift(shift);
                        Console.WriteLine();
                    }
                    break;
                case 9:
                    foreach (var employee in DB.employees)
                    {
                        PrintEmployee(employee);
                        Console.WriteLine();
                    }
                    break;
                case 10:
                    foreach (var jobTitle in DB.positions)
                    {
                        PrintJobTitle(jobTitle);
                        Console.WriteLine();
                    }
                    break;
                case 11:
                    foreach (var subdivision in DB.subdivisions)
                    {
                        PrintSubdivision(subdivision);
                        Console.WriteLine();
                    }
                    break;
                case 12:
                    foreach (var organization in DB.organizations)
                    {
                        PrintOrganization(organization);
                        Console.WriteLine();
                    }
                    break;
                case 13:
                    foreach (var typeOfActivity in DB.TypesOfActivity)
                    {
                        PrintTypeOfActivity(typeOfActivity);
                        Console.WriteLine();
                    }
                    break;
                case 14:
                    foreach (var lesson in DB.lessons)
                    {
                        PrintLesson(lesson);
                        Console.WriteLine();
                    }
                    break;
                case 15:
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }
}