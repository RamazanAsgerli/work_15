using Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;

        public int Id { get;set; }

        string _name;
        public string Name {
            get { return _name; }
            set
            {
                if ((value[0]>='A' && value[0] <='Z') && value.Length > 3)
                {
                    _name = value;
                }
                else
                {
                    throw new NameException("Boyuk herfle baslamalidi ve uzunluq 3 den cox olmalidi");
                }
            }
        }

        string _surname;
        public string Surname
        { get { return _surname; }
            set
            {
                if ((value[0] >= 'A' && value[0] <= 'Z') && value.Length > 3)
                {
                    _name = value;
                }
                else
                {
                    throw new NameException("Boyuk herfle baslamalidi ve uzunluq 3 den cox olmalidi");
                }
            }
                
                
        }

       

        public Student(string name3,string surname1)
        {
            _id++;
            Id = _id;
            _name = name3;
            _surname = surname1;
        }

        public override string ToString()
        {
            return $"Id: {Id},Name: {Name},Surname: {Surname}";
        }


    }
}
