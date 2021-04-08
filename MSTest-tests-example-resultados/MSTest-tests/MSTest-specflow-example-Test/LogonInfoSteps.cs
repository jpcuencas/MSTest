using System;
using TechTalk.SpecFlow;
using MSTest_tests_example.Private;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_specflow_example_Test
{
    [Binding]
    public class LogonInfoSteps
    {
        PrivateType logonInfo;
        bool actual;

        [Given(@"a PrivateType of LogonInfo")]
        public void GivenAPrivateTypeOfLogonInfo()
        {
            logonInfo = new PrivateType(typeof(LogonInfo));
        }

        [When(@"I check the validity of the ""(.*)""")]
        public void WhenICheckTheValidityOfThe(string password)
        {
            try
            {
                actual = (bool)logonInfo.InvokeStatic("IsValidPassword", password, String.Empty);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Password", ex);
            }
        }

        [Then(@"the result of validity should be (.*)")]
        public void ThenTheResultOfValidityShouldBeTrue(bool expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
