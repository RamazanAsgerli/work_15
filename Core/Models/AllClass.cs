using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
     public class AllClass
    {
        public Classrom[] ClassRooms;

        public AllClass()
        {
            ClassRooms = new Classrom[0];
        }

        public void AddClass(Classrom classrooms)
        {
            Array.Resize(ref ClassRooms, ClassRooms.Length+1);
            ClassRooms[ClassRooms.Length - 1] = classrooms;
        }

        public Classrom FindClass(string className)
        {
            foreach (var classroom in ClassRooms)
            {
                if (classroom.Name == className)
                {
                    return classroom;
                }
            }
            return null;
        }
        public Classrom[] GetAllStudents()
        {
            return ClassRooms;
        }

    }
}
