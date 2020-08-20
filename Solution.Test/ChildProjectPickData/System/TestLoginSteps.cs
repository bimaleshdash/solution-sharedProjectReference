using ProjectReferredCommon.Collection;
using System;
using TechTalk.SpecFlow;

namespace ChildProjectPickData.System
{
    [Binding]
    public class TestLoginSteps
    {
        [Given(@"login as (.*)")]
        [When(@"login as (.*)")]
        public void LogIntoCompany(string companyName)
        {
            var datahubUrl = Runner.Config.datahub.url;
            Runner.Driver.Navigate().GoToUrl(datahubUrl);

            var page = new Pages.UserPortal.LoginPage(TestSetup.Driver);
            page.Login(TestSetup.Config.datahub.username, TestSetup.Config.datahub.password);

            var page2 = new Pages.UserPortal.CompanyList(TestSetup.Driver);
            page2.SelectCompany(companyName).SignIn();
        }

        [Given(@"wait and close Walk Me Through popup")]
        [When(@"wait and close Walk Me Through popup")]
        public void WaitAndCloseWalkMeThroughPopup()
        {
            try
            {
                var page = new Pages.DataHub.WalkMeThroughPopup(TestSetup.Driver);
                page.Close();
            }
            catch (WebDriverTimeoutException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Probably WalkMeThrough is turned off. Continuing...");
            }
        }
    }
}
