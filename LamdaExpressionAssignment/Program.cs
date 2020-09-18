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
            List<string> averageJoes = new List<string>();
            
            List<Employee> Employees = new List<Employee>();
            
            List<string> firstNames = new List<string>()
            {
                "Gord", "Shep", "Butch", "Joe", "Range", "Villanova", "Joe", "Planters", "Ewel", "Anderson"
            };

            List<string> lastNames = new List<string>()
            {
                "Buell", "Sheppard", "Weaver", "Knutsen", "Blllhlll", "Giraffe", "Hoisin", "Monopoly", "Peck", "Cooper"
            };

            List<int> IDs = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int i = 0;
            foreach (var firstName in firstNames)
            {
               Employees.Add(new Employee(firstName, lastNames[i], IDs[i]));
                i++;
            }
            
            foreach (Employee employee in Employees)
            {
                if (employee.firstName.Equals ("Joe"))
                { 
                averageJoes.Add(employee.firstName);
                }
            }
            Console.WriteLine(averageJoes);
            Console.ReadLine();

           
            List<Employee> joeList = Employees.firstNames.Where(x => x.firstName == x.Joe).ToList();

            
            List<Employee> fiveList = Employees.ID.Where(x => x > 5).ToList();
            
        }
    }
}
