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
        static Employee employeeData { get; set; }
        delegate void MyEventHandler(object sender);
        event MyEventHandler MyEvent;
        //CmdBridge cmdBridge;

        public Employee()
        {
            //firstName = "Varun";
            //lastName = "Sharma";
            //cmdBridge = new CmdBridge();
            //MyEvent += cmdBridge.invokeFunction;
        }

        public string employeeName()
        {
            //MyEvent(this);
            CmdBridge.assignResult(this);
            employeeData = this;
            return this.firstName + " " + this.lastName;
        }

        public static Employee sayHello(Employee obj)
        {
            return obj;
            //return "Hello there";
        }

        //public static object Create()
        //{
        //    object newEmployee = new Employee();
        //    return newEmployee;
        //}
        public void registerEvent()
        {
            //MyEvent += (object sender) =>
            // {
            //     var eventData = ((RuntimeComponent1.Employee)sender);
            // };


        }
    }

    public sealed class CmdBridge
    {
        private static CmdBridge singletonObj;
        private Object finalObj;

        public CmdBridge()
        {

        }

        private CmdBridge(Object apiResponse)
        {
            finalObj = apiResponse;
        }

        public static void assignResult(Object result)
        {
            if (singletonObj == null)
            {
                singletonObj = new CmdBridge(result);
            }
        }

        public static object getResult()
        {
            return singletonObj.finalObj;
        }

        public void assignTempObjResult(Object obj)
        {

        }
    }

}
