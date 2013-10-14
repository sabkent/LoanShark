using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanShark.Domain.Core;
using NUnit.Framework;

namespace LoanShark.Test
{
    [TestFixture]
    public class ApplicationTest
    {
        //[Test]
        //public void BasicTester()
        //{
        //    ApplicationRequest applicationRequest = new ApplicationRequest() { Person = new Person() { FirstName = "Dean", LastName = "Havelock" } };
        //
        //    ApplicationProcessor applicationProcessor = new ApplicationProcessor(applicationRequest);
        //    ApplicationResponse applicationResponse = applicationProcessor.Process();
        //    Assert.IsFalse(applicationResponse.LoanAccepted);
        //}

        [Test]
        public void CanProcessRejectWithNullPersonFirstName()
        {
            ApplicationRequest applicationRequest = new ApplicationRequest() { Person = new Person() { FirstName = null, LastName = "Havelock" }, Bank = new Bank(){Name = "Lloyds Bank"}};

            ApplicationProcessor applicationProcessor = new ApplicationProcessor(applicationRequest);
            ApplicationResponse applicationResponse = applicationProcessor.Process();
            Assert.IsFalse(applicationResponse.LoanAccepted);
        }

        [Test]
        public void CanProcessRejectWithNullBankName()
        {
            ApplicationRequest applicationRequest = new ApplicationRequest() { Person = new Person() { FirstName = "Dean", LastName = "Havelock" }, Bank = new Bank(){Name = null}};

            ApplicationProcessor applicationProcessor = new ApplicationProcessor(applicationRequest);
            ApplicationResponse applicationResponse = applicationProcessor.Process();
            Assert.IsFalse(applicationResponse.LoanAccepted);
        }
    

    }
}
