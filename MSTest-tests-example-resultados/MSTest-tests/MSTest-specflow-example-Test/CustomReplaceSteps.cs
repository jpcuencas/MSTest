using System;
using TechTalk.SpecFlow;
using MSTest_tests_example.Basics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_specflow_example_Test
{
    [Binding]
    public class CustomReplaceSteps
    {
        CustomReplacer customReplacer;
        String actual;

        [Given(@"a custom replace object")]
        public void GivenACustomReplaceObject()
        {
            customReplacer = new CustomReplacer();
        }
        
        [When(@"replace the letter ""(.*)"" in the text ""(.*)""")]
        public void WhenReplaceTheLetterInTheText(string letter, string text)
        {
            try
            {
                actual = customReplacer.CustomReplace(text, letter);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_CustomReplace", ex);
            }
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
