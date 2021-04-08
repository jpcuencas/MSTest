using System;
using TechTalk.SpecFlow;
using MSTest_tests_example.Mocks.Date;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest_specflow_example_Test
{
    [Binding]
    public class ImageManagementSteps
    {
        Mock<ImageManagement> imangeManagementMock;
        String actual; 

        [Given(@"a ImageManagement Mock")]
        public void GivenAImageManagementMock()
        {
            imangeManagementMock = new Mock<ImageManagement>();
        }
        
        [Given(@"setting up the retun value of GetHour method to (.*)")]
        public void GivenSettingUpTheRetunValueOfGetHourMethodTo(int hour)
        {
            try
            {
                imangeManagementMock.CallBase = true;
                imangeManagementMock.Setup(dat => dat.GetHour()).Returns(hour);
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Triangle", ex);
            }
        }
        
        [When(@"get the image for time of day")]
        public void WhenGetTheImageForTimeOfDay()
        {
            try
            {
                actual = imangeManagementMock.Object.GetImageForTimeOfDay();
            }
            catch (Exception ex)
            {
                ScenarioContext.Current.Add("Exception_Image", ex);
            }
        }
        
        [Then(@"the result image should be ""(.*)""")]
        public void ThenTheResultImageShouldBe(string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
