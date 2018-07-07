using NUnit.Framework;
using SpecFlowDemo;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int _result;
        private Calculator _calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _calculator.FirstNumber = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            _calculator.SecondNumber = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }
    }
}
