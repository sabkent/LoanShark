using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanShark.Domain.Core.ApplicationStages
{
    public class NameNotNullCheck : IApplicationStageCheck
    {
        private string _name;

        public NameNotNullCheck(string name)
        {
            _name = name;
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(_name);
        }
    }
}
