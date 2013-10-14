using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanShark.Domain.Core.ApplicationStages
{
    public class BankCheck : IApplicationStageCheck
    {
        private NameNotNullCheck _nameNotNullCheck;
        private Bank _bank;

        public BankCheck(Bank bank)
        {
            _bank = bank;
            _nameNotNullCheck = new NameNotNullCheck(_bank.Name);
        }

        public bool Validate()
        {
            return _nameNotNullCheck.Validate();
        }
    }
}
