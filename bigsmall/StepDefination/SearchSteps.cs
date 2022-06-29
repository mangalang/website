using bigsmall.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace bigsmall.StepDefination
{
    [Binding]
    public class SearchSteps
    {
        SearchObject srchobj = new SearchObject();
        [Given(@"The homepage of BigSmall Shopping site Page")]
        public void GivenTheHomepageOfBigSmallShoppingSitePage()
        {
            srchobj.HomePage();
        }
        
        [When(@"User Click on Search bar")]
        public void WhenUserClickOnSearchBar()
        {
            srchobj.OnSitePage();
        }

        [When(@"User enters ""(.*)"" data")]
        public void WhenUserEntersData(string SearchData)
        {
            srchobj.ClickOnSearch(SearchData);
        }

        [Then(@"System should display relevant search data")]
        public void ThenSystemShouldDisplayRelevantSearchData()
        {
            srchobj.VerifyResult();
        }
    }
}
