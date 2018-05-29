using System;
using TechTalk.SpecFlow;
using Keys.Global;
using Keys.Pages;
using RelevantCodes.ExtentReports;

namespace Keys
{
    [Binding]
    public class POListARentalSteps : Base
    {
        [Given(@"I have Navigated to List A Rental")]
        public void GivenIHaveNavigatedToListARental()
        {
            //Navigate to List A Rental page
            test = extent.StartTest("List A Rental");
            Owner_ListARental LRentalobj = new Owner_ListARental();
            LRentalobj.ListRentalPage();
           // test.Log(LogStatus.Pass, "Navigated to List A Rental Page");
        }
        
        [Given(@"I have entered valid mandatory fields and press Save")]
        public void GivenIHaveEnteredValidMandatoryFieldsAndPressSave()
        {
            //Save mandatory fields
            test = extent.StartTest("List A Rental");
            Owner_ListARental LRentalobj = new Owner_ListARental();
            LRentalobj.LARSave();
        }
        
        [Then(@"the property listed is verified")]
        public void ThenThePropertyListedIsVerified()
        {
            //Verify property has been listed
            test = extent.StartTest("List A Rental");
            Owner_ListARental LRentalobj = new Owner_ListARental();
            LRentalobj.LARverify();
        }
    }
}
