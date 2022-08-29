using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Concepts
{
    public class Details
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string getDetails()
        {
            return "FirstNme is " + Firstname + " lastName is " + Lastname;
        }


        // polymorphism
        public int add()
        {
            return 2 + 2;
        }
        public int add(int a, int b)
        {
            return a + b;
        }

        public decimal add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
    }

    public class Student : Details
    {
        public string StudentAdress { get; set; }
    }

    public class Teacher : Details
    {
        public string Subject { get; set; } 
    }
}
