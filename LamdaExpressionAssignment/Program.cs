using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressionAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> averageJoes = new List<Employee>();

            List<Employee> Employees = new List<Employee>();
            {
                new Employee { firstName = "Gord", lastName = "Buell", ID = 1 };
                new Employee { firstName = "Shep", lastName = "Sheppard", ID = 2 };
                new Employee { firstName = "Butch", lastName = "Weaver", ID = 3 };
                new Employee { firstName = "Joe", lastName = "Knutsen", ID = 4 };
                new Employee { firstName = "Range", lastName = "Blllhlll", ID = 5 };
                new Employee { firstName = "Villanova", lastName = "Giraffe", ID = 6 };
                new Employee { firstName = "Joe", lastName = "Hoisin", ID = 7 };
                new Employee { firstName = "Planters", lastName = "Monopoly", ID = 8 };
                new Employee { firstName = "Ewel", lastName = "Peck", ID = 9 };
                new Employee { firstName = "Anderson", lastName = "Cooper", ID = 10 };

    
                foreach (Employee employee in Employees)
                {
                    if (employee.firstName.Equals("Joe"))
                    {
                        averageJoes.Add(employee);
                    }
                }
                Console.WriteLine(averageJoes);
                Console.ReadLine();


                List<Employee> joeList = Employees.Where(x => x.firstName == "Joe").ToList();


                List<Employee> fiveList = Employees.Where(x => x.ID > 5).ToList();

            }
        }
    }

}