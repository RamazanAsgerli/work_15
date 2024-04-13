using Core.Enums;
using Core.Models;
using System.Collections;

namespace task15
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            

            try
            {
                Classrom classrooms = new Classrom("BB207", ClassType.BackEnd);
                Classrom classrooms1 = new Classrom("AA207", ClassType.FrontEnd);
                AllClass allClass = new AllClass();
                allClass.AddClass(classrooms1);
                allClass.AddClass(classrooms);
                bool check1 = true;
                do
                {

                    Console.WriteLine("1.Classroom yarat");
                    Console.WriteLine("2.Student yarat");
                    Console.WriteLine("3.Butun Telebeleri ekrana cixart");
                    Console.WriteLine("4.Secilmis sinifdeki telebeleri ekrana cixart");
                    Console.WriteLine("5.Telebe sil");

                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":

                            Console.WriteLine("Classrom adi daxil et");
                            string name = Console.ReadLine();
                            Console.WriteLine("Tipini daxil et");
                            if (Enum.TryParse(Console.ReadLine(), out ClassType type))
                            {
                                Classrom newClassroom = new Classrom(name, type);
                                allClass.AddClass(newClassroom);
                                Console.WriteLine("Yaradildi");
                            }
                            else
                            {
                                Console.WriteLine("Duzgun daxil edin");
                            }
                            break;
                        case "2":
                            bool check = true;

                            Console.WriteLine("Name:");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Surname:");
                            string surname = Console.ReadLine();
                            Student student1 = new Student(name1, surname);
                            classrooms.AddStudent(student1);

                            break;
                        case "3":
                            Student[] students = classrooms.GetAllStudents();
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine(students[i].ToString());
                            }
                            break;
                        case "4":
                            Console.WriteLine("Class adi daxil edin");
                            string className = Console.ReadLine();
                            Classrom selectedClass = allClass.FindClass(className);
                            if (selectedClass != null)
                            {
                                Student[] Students = selectedClass.GetAllStudents();
                                foreach (var student in Students)
                                {
                                    Console.WriteLine(student.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bele sinif yoxdur");
                            }
                            

                            break;
                        case "5":
                            int _id;
                            do
                            {
                                Console.WriteLine("id daxil et:");

                            } while (!int.TryParse(Console.ReadLine(), out _id));
                            classrooms.Delete(_id);
                            break;
                    }

                } while (check1);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
           
        }
    }
}
