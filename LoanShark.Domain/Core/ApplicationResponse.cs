using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanShark.Domain.Core
{
    public class ApplicationResponse
    {
        private readonly bool _loanAccepted;

        public ApplicationResponse(bool loanAccepted)
        {
            _loanAccepted = loanAccepted;
        }

        public bool LoanAccepted
        {
            get { return _loanAccepted; }
        }
    }
}
