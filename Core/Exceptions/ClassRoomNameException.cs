using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class ClassRoomNameException:Exception
    {
        public ClassRoomNameException(string message):base(message) 
        {

        }
    }
}
