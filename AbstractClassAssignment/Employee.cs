using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: [" + firstName + lastName + "]");
        }

        //Step 245 Overloaded Operator Assignment:
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);
        }

    }





    }
