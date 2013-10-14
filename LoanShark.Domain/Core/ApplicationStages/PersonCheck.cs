using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanShark.Domain.Core.ApplicationStages
{
    public class PersonCheck : IApplicationStageCheck
    {
        private NameNotNullCheck _nameNotNullCheck;
        private Person _person;

        public PersonCheck(Person person)
        {
            _person = person;
            _nameNotNullCheck = new NameNotNullCheck(_person.FirstName);
        }

        public bool Validate()
        {
            return _nameNotNullCheck.Validate();
        }
    }
}
