using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b001BddTest2
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        int int1;
        int int2;
        int result;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            int1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            int2 = p0;
        }
        
        [When(@"the two numbers are addiert")]
        public void WhenTheTwoNumbersAreAddiert()
        {
            result = int1 + int2;
        }
        
        [When(@"the two numbers are subdrahiert")]
        public void WhenTheTwoNumbersAreSubdrahiert()
        {
            result = int1 - int2;
        }
        
        [When(@"the two numbers are multipliziert")]
        public void WhenTheTwoNumbersAreMultipliziert()
        {
            result = int1 * int2;
        }
        
        [When(@"the two numbers are dividiert")]
        public void WhenTheTwoNumbersAreDividiert()
        {
            result = int1 / int2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.Equal(p0, result);
        }
    }
}
