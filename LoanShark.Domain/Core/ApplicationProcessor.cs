using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanShark.Domain.Core.ApplicationStages;

namespace LoanShark.Domain.Core
{
    public class ApplicationProcessor
    {
        private List<IApplicationStageCheck> _applicationStageChecks; 
        private ApplicationRequest _applicationRequest;


        public ApplicationProcessor(ApplicationRequest applicationRequest)
        {
            _applicationRequest = applicationRequest;
            _applicationStageChecks = new List<IApplicationStageCheck>(){new PersonCheck(applicationRequest.Person), new BankCheck(applicationRequest.Bank)};
        }

        public ApplicationResponse Process()
        {
            List<bool> results = new List<bool>();

            foreach (var applicationStageCheck in _applicationStageChecks)
            {
                 results.Add(applicationStageCheck.Validate());
            }
            if(results.Contains(false))
                return new ApplicationResponse(false);
            return new ApplicationResponse(true);
        }
    }
}
