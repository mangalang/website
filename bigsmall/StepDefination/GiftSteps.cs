using bigsmall.CommonMethodObject;
using System;
using TechTalk.SpecFlow;

namespace bigsmall.StepDefination
{
    [Binding]
    public class GiftSteps
    {
        GiftObject giftobj = new GiftObject();

        [Given(@"User Clicks on Gift card")]
        public void GivenUserClicksOnGiftCard()
        {
            giftobj.ClickOnGiftCard();
        }
        
        [When(@"User Clicks on price")]
        public void WhenUserClicksOnPrice()
        {
            giftobj.ClickOnPrice();
        }
        
        [When(@"USer Clicks on Wishlist")]
        public void WhenUSerClicksOnWishlist()
        {
            giftobj.ClickOnWishlit();   
        }
        
        [When(@"User Enters PinCode")]
        public void WhenUserEntersPinCode()
        {
            giftobj.EnterPincode();
        }
        
        [When(@"User Clicks on Check Button")]
        public void WhenUserClicksOnCheckButton()
        {
            giftobj.ClickOnCheck();
        }
        
        [When(@"User Clicks on Add to cart")]
        public void WhenUserClicksOnAddToCart()
        {
            giftobj.ClickOnAddToCart();
        }
        
        [Then(@"User Click on Continue Shopping")]
        public void ThenUserClickOnContinueShopping()
        {
            giftobj.ClickOnContinueShopping();
        }
    }
}
