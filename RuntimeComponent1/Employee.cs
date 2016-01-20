using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace RuntimeComponent1
{
    public sealed class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        
        public Employee()
        {
            firstName = "Varun";
            lastName = "Sharma";
        }

        public string EmployeeName()
        {
            return this.firstName + " " + this.lastName;
        }

        public static string SayHello()
        {
            return "Hello there";
        }

        //public static object Create()
        //{
        //    object newEmployee = new Employee();
        //    return newEmployee;
        //}
    }
}
