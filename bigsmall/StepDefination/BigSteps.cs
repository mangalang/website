using bigsmall.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace bigsmall.StepDefination
{
    [Binding]
    public class BigSteps
    {
        BigObject bigobj = new BigObject();
        [Given(@"user clicks on sale")]
        public void GivenUserClicksOnSale()
        {
            bigobj.sale();
        }
        
        [When(@"user clicks on fairy lights")]
        public void WhenUserClicksOnFairyLights()
        {
            bigobj.lights();
        }
        
        [When(@"User clicks on add to wish list")]
        public void WhenUserClicksOnAddToWishList()
        {
            bigobj.wishlist();
        }
        
        /*[When(@"User Clicks on view Your wishList")]
        public void WhenUserClicksOnViewYourWishList()
        {
            bigobj.viewwish();
        }*/
        
        [When(@"User Clicks on add to cart")]
        public void WhenUserClicksOnAddToCart()
        {
            bigobj.cart();
        }
        
        [Then(@"User Click On Go To CheckOut")]
        public void ThenUserClickOnGoToCheckOut()
        {
            bigobj.checkout();
        }
    }
}
