using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderNo = "123";
            order.OrderValue = "1000";
            order.OrderCountry = "India";

            order.CrateOrder();

            Student student = new Student();
            student.Firstname = "Student 1";
            student.Lastname = "lastName ";
            student.StudentAdress = "test address ";
            student.getDetails();
        }
    }
}
