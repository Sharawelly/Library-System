using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberarySystem.LiberaryClasses
{
    // store all applicatoin data inside it 
    class LiberarySystem
    {
        public int GetId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordAgain { get; set; }
        public string Gender { get; set; }

    }


    class Admin : LiberarySystem
    {
        public Admin()
        {

        }
        static int idd = 2;
        public int getidd()
        {
            idd++;
            return idd;
        }
        public string Role { get; set; }
        public string Department { get; set; }
    }


    class Student : LiberarySystem
    {
        public Student() { }
        static int id = 0;
        public int getid()
        {
            id++;
            return id;
        }
        public string SecondName { get; set; }
        public string LastName { get; set; }
    }

    class LogIn
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool CheckAdminOrStudent { get; set; }

    }
    class category : LiberarySystem
    {
        private static int count = 0;
        public category()
        {
            count++;
        }

        public int Count()
        {
            return count;
        }
    }
}