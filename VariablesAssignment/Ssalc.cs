using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAssignment
{
    class Ssalc
    {
        public Ssalc(string firstname) : this(firstname, string.Empty)
        {
        }

        public Ssalc(string firstname, string lastname)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            
        }
    public string firstName { get; set; }
    public string lastName { get; set; }
    }
    
}
