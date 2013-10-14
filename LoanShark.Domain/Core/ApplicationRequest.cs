using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanShark.Domain.Core
{
    public class ApplicationRequest
    {
        public Person Person { get; set; }
        public Bank Bank { get; set; }
    }
}
