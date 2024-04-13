
using Core.Enums;
using Core.Exceptions;

namespace Core.Models
{
    public class Classrom
    {
        private static int _id;
        public int Id { get;set; }

        string _name;
        public string Name 
        { get { return _name; }
          set
            {
                if(value.Length == 5 && char.IsUpper(value[0]) && char.IsUpper(value[1]) && char.IsDigit(value[2]) && char.IsDigit(value[3]) && char.IsDigit(value[4]))
                {
                    _name = value;
                }
                else
                {
                    throw new ClassRoomNameException("Duzgun daxil edin");
                }
            } 
        }

        public Student[] Students;
        
        public ClassType Type { get; set; }
        public Classrom(string name,ClassType type)
        {
            Name = name;
            Type = type;
            _id++;
            Id = _id;
           Students = new Student[0];
           
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1] = student;
        }
       
        public Student FindId(int id) 
        {
            foreach (Student student in Students)
            {
                if(student.Id == id) return student;
            }

            return null;
        }

        public void Delete(int id)
        {
            Student[] newStudents = { };
            foreach (Student student in Students)
            {
                if (student.Id != id)
                {
                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[newStudents.Length - 1] = student;
                }
            }
            Students = newStudents;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }
        
    }
}
