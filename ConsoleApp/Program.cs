using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static List<Lesson> lessons = new List<Lesson>();
        static List<Classroom> classrooms = new List<Classroom>();
        static List<Discipline> disciplines = new List<Discipline>();
        static List<Group> groups = new List<Group>();
        static List<Student> students = new List<Student>();
        static List<Speciality> specialties = new List<Speciality>();
        static List<Pair> pairs = new List<Pair>();
        static List<Shift> shifts = new List<Shift>();
        static List<Employee> employees = new List<Employee>();
        static List<Job_title> positions = new List<Job_title>();
        static List<Subdivision> subdivisions = new List<Subdivision>();
        static List<Organization> organizations = new List<Organization>();
        static List<Body> bodies = new List<Body>();

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Создать занятие");
                Console.WriteLine("2. Создать аудиторию");
                Console.WriteLine("3. Создать дисциплину");
                Console.WriteLine("4. Создать группу");
                Console.WriteLine("5. Создать студента");
                Console.WriteLine("6. Создать специальность");
                Console.WriteLine("7. Создать пару");
                Console.WriteLine("8. Создать смену");
                Console.WriteLine("9. Создать сотрудника");
                Console.WriteLine("10. Создать должность");
                Console.WriteLine("11. Создать подразделение");
                Console.WriteLine("12. Создать организацию");
                Console.WriteLine("13. Создать корпус");
                Console.WriteLine("14. Выход");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateLesson();
                        break;
                    case 2:
                        CreateClassroom();
                        break;
                    case 3:
                        CreateDiscipline();
                        break;
                    case 4:
                        CreateGroup();
                        break;
                    case 5:
                        CreateStudent();
                        break;
                    case 6:
                        CreateSpeciality();
                        break;
                    case 7:
                        CreatePair();
                        break;
                    case 8:
                        CreateShift();
                        break;
                    case 9:
                        CreateEmployee();
                        break;
                    case 10:
                        CreateJobTitle();
                        break;
                    case 11:
                        CreateSubdivision();
                        break;
                    case 12:
                        CreateOrganization();
                        break;
                    case 13:
                        CreateBody();
                        break;
                    case 14:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                        break;
                }
            }
        }

        static void CreateLesson()
        {
            Console.WriteLine("Введите название дисциплины:");
            string disciplineName = Console.ReadLine();
            Discipline discipline = disciplines.FirstOrDefault(d => d.Name.ToLower() == disciplineName.ToLower());
            if (discipline == null)
            {
                Console.WriteLine("Дисциплина не найдена. Создание занятия отменено.");
                return;
            }

            Console.WriteLine("Введите ФИО преподавателя:");
            string employeeName = Console.ReadLine();
            Employee employee = employees.FirstOrDefault(e => e.FullName.ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Преподаватель не найден. Создание занятия отменено.");
                return;
            }

            Console.WriteLine("Введите номер аудитории:");
            string classroomNumber = Console.ReadLine();
            Classroom classroom = classrooms.FirstOrDefault(c => c.Number == classroomNumber);
            if (classroom == null)
            {
                Console.WriteLine("Аудитория не найдена. Создание занятия отменено.");
                return;
            }

            Console.WriteLine("Введите номер пары от 1 до 7:");
            int pairNumber = Convert.ToInt32(Console.ReadLine());
            Pair pair = pairs.FirstOrDefault(p => p.Number == pairNumber);
            if (pair == null)
            {
                Console.WriteLine("Пара не найдена. Создание занятия отменено.");
                return;
            }

            Console.WriteLine("Введите название группы:");
            string groupName = Console.ReadLine();
            Group group = groups.FirstOrDefault(g => g.Name.ToLower() == groupName.ToLower());
            if (group == null)
            {
                Console.WriteLine("Группа не найдена. Создание занятия отменено.");
                return;
            }

            Console.WriteLine("Введите букву корпуса:");
            string bodyLetter = Console.ReadLine().ToUpper();
            Body body = bodies.FirstOrDefault(b => b.Letter == bodyLetter);
            if (body == null)
            {
                Console.WriteLine("Корпус не найден. Создание занятия отменено.");
                return;
            }

            Lesson lesson = new Lesson(null, discipline, employee, classroom, group, pair, body);
            lessons.Add(lesson);
            Console.WriteLine("Занятие успешно создано.");
        }

        static void CreateClassroom()
        {
            Console.WriteLine("Введите номер аудитории:");
            string classroomNumber = Console.ReadLine();

            Console.WriteLine("Введите ФИО ответственного сотрудника:");
            string employeeName = Console.ReadLine();

            Employee employee = employees.FirstOrDefault(e => e.FullName.ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Сотрудник не найден. Создание аудитории отменено.");
                return;
            }

            Console.WriteLine("Введите количество мест в аудитории:");
            int places = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество окон в аудитории:");
            int windows = Convert.ToInt32(Console.ReadLine());

            Classroom classroom = new Classroom(classroomNumber, employee, places, windows);
            classrooms.Add(classroom);

            Console.WriteLine("Аудитория успешно создана.");
        }

        static void CreateDiscipline()
        {
            Console.WriteLine("Введите название дисциплины:");
            string disciplineName = Console.ReadLine();

            Console.WriteLine("Введите короткое название дисциплины:");
            string disciplineShortName = Console.ReadLine();

            Discipline discipline = new Discipline(disciplineName, disciplineShortName);
            disciplines.Add(discipline);

            Console.WriteLine("Дисциплина успешно создана.");
        }

        static void CreateGroup()
        {
            Console.WriteLine("Введите название группы:");
            string groupName = Console.ReadLine();

            Console.WriteLine("Введите короткое название группы:");
            string groupShortName = Console.ReadLine();

            Console.WriteLine("Введите количество студентов в группе:");
            int groupQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название специальности:");
            string specialityName = Console.ReadLine();
            Speciality speciality = specialties.FirstOrDefault(s => s.Name.ToLower() == specialityName.ToLower());
            if (speciality == null)
            {
                Console.WriteLine("Специальность не найдена. Создание группы отменено.");
                return;
            }

            Console.WriteLine("Введите ФИО куратора группы:");
            string employeeName = Console.ReadLine();
            Employee employee = employees.FirstOrDefault(e => e.FullName.ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Куратор не найден. Создание группы отменено.");
                return;
            }

            Console.WriteLine("Введите год создания группы (пустое значение означает текущий год):");
            string yearInput = Console.ReadLine();
            int year = yearInput == "" ? DateTime.Now.Year : Convert.ToInt32(yearInput);

            Group group = new Group(groupName, groupShortName, groupQuantity, speciality, employee, year);
            groups.Add(group);
            Console.WriteLine("Группа успешно создана.");
        }

        static void CreateStudent()
        {
            Console.WriteLine("Введите фамилию студента:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите отчество студента:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите название группы студента:");
            string groupName = Console.ReadLine();
            Group group = groups.FirstOrDefault(g => g.Name.ToLower() == groupName.ToLower());
            if (group == null)
            {
                Console.WriteLine("Группа не найдена. Создание студента отменено.");
                return;
            }

            Console.WriteLine("Введите дату рождения студента (пустое значение означает текущую дату):");
            string birth = Console.ReadLine();

            Student student = new Student(surname, name, patronymic, group, birth);
            students.Add(student);
            Console.WriteLine("Студент успешно создан.");
        }

        static void CreateSpeciality()
        {
            Console.WriteLine("Введите название специальности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название специальности:");
            string abbreviation = Console.ReadLine();

            Console.WriteLine("Введите дату создания специальности (пустое значение означает текущую дату):");
            string date = Console.ReadLine();

            Speciality speciality = new Speciality(name, abbreviation, date);
            specialties.Add(speciality);
            Console.WriteLine("Специальность успешно создана.");
        }

        static void CreatePair()
        {
            Console.WriteLine("Введите время начала пары (в формате чч:мм):");
            string timePairStart = Console.ReadLine();

            Console.WriteLine("Введите время окончания пары (в формате чч:мм):");
            string timePairEnd = Console.ReadLine();

            Console.WriteLine("Введите время начала перерыва (в формате чч:мм):");
            string timeBreakStart = Console.ReadLine();

            Console.WriteLine("Введите время окончания перерыва (в формате чч:мм):");
            string timeBreakEnd = Console.ReadLine();

            Console.WriteLine("Введите название смены:");
            string shiftName = Console.ReadLine();
            Shift shift = shifts.FirstOrDefault(s => s.Name.ToLower() == shiftName.ToLower());
            if (shift == null)
            {
                Console.WriteLine("Смена не найдена. Создание пары отменено.");
                return;
            }

            Pair pair = new Pair(timePairStart, timePairEnd, timeBreakStart, timeBreakEnd, shift);
            pairs.Add(pair);
            Console.WriteLine("Пара успешно создана.");
        }

        static void CreateShift()
        {
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите дату создания смены (пустое значение означает текущую дату):");
            string date = Console.ReadLine();

            Shift shift = new Shift(name, date);
            shifts.Add(shift);
            Console.WriteLine("Смена успешно создана.");
        }

        static void CreateEmployee()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите название должности:");
            string jobTitleName = Console.ReadLine();
            Job_title jobTitle = positions.FirstOrDefault(j => j.Name.ToLower() == jobTitleName.ToLower());
            if (jobTitle == null)
            {
                Console.WriteLine("Должность не найдена. Создание сотрудника отменено.");
                return;
            }

            Employee employee = new Employee(name, surname, patronymic, jobTitle);
            employees.Add(employee);
            Console.WriteLine("Сотрудник успешно создан.");
        }

        static void CreateJobTitle()
        {
            Console.WriteLine("Введите название должности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите зарплату должности:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название подразделения:");
            string subdivisionName = Console.ReadLine();
            Subdivision subdivision = subdivisions.FirstOrDefault(s => s.Name.ToLower() == subdivisionName.ToLower());
            if (subdivision == null)
            {
                Console.WriteLine("Подразделение не найдено. Создание должности отменено.");
                return;
            }

            Job_title jobTitle = new Job_title(name, salary, subdivision);
            positions.Add(jobTitle);
            Console.WriteLine("Должность успешно создана.");
        }

        static void CreateSubdivision()
        {
            Console.WriteLine("Введите название подразделения:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество директора:");
            string directorFullName = Console.ReadLine();
            Employee director = employees.FirstOrDefault(e => e.FullName == directorFullName);
            if (director == null)
            {
                Console.WriteLine("Директор не найден. Создание подразделения отменено.");
                return;
            }

            Console.WriteLine("Введите название организации:");
            string organizationName = Console.ReadLine();
            Organization organization = organizations.FirstOrDefault(o => o.Name.ToLower() == organizationName.ToLower());
            if (organization == null)
            {
                Console.WriteLine("Организация не найдена. Создание подразделения отменено.");
                return;
            }

            Subdivision subdivision = new Subdivision(name, director, organization);
            subdivisions.Add(subdivision);
            Console.WriteLine("Подразделение успешно создано.");
        }

        static void CreateOrganization()
        {
            Console.WriteLine("Введите название организации:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите юридический адрес организации:");
            string legalAddress = Console.ReadLine();

            Console.WriteLine("Введите фактический адрес организации:");
            string actualAddress = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество руководителя организации:");
            string supervisorFullName = Console.ReadLine();
            Employee supervisor = employees.FirstOrDefault(e => e.FullName == supervisorFullName);
            if (supervisor == null)
            {
                Console.WriteLine("Руководитель не найден. Создание организации отменено.");
                return;
            }

            Organization organization = new Organization(name, legalAddress, actualAddress, supervisorFullName, supervisor);
            organizations.Add(organization);
            Console.WriteLine("Организация успешно создана.");
        }

        static void CreateBody()
        {
            Console.WriteLine("Введите название корпуса:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите адрес корпуса:");
            string address = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество коменданта корпуса:");
            string commandantFullName = Console.ReadLine();
            Employee commandant = employees.FirstOrDefault(e => e.FullName == commandantFullName);
            if (commandant == null)
            {
                Console.WriteLine("Комендант не найден. Создание корпуса отменено.");
                return;
            }

            Console.WriteLine("Введите фамилию, имя и отчество студента, который будет проживать в корпусе:");
            string studentFullName = Console.ReadLine();
            Student student = students.FirstOrDefault(s => s.FullName == studentFullName);
            if (student == null)
            {
                Console.WriteLine("Студент не найден. Создание корпуса отменено.");
                return;
            }

            Console.WriteLine("Введите название организации, которой принадлежит корпус:");
            string organizationName = Console.ReadLine();
            Organization organization = organizations.FirstOrDefault(o => o.Name.ToLower() == organizationName.ToLower());
            if (organization == null)
            {
                Console.WriteLine("Организация не найдена. Создание корпуса отменено.");
                return;
            }

            Body body = new Body(name, address, commandantFullName, student, organization);
            bodies.Add(body);
            Console.WriteLine("Корпус успешно создан.");
        }
    }
}
