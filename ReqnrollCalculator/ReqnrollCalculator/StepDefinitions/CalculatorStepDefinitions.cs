using NUnit.Framework;
using Reqnroll;

namespace ReqnrollCalculator.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private Calculator calculator = new Calculator();
        private int actualResult;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            calculator.FirstNumber = firstNumber;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            calculator.SecondNumber = secondNumber;
        }

        [When("the numbers are (.*)")]
        public void WhenTheNumbersAreOperated(string operation)
        {
            switch (operation.ToLower())
            {
                case "added":
                    actualResult = calculator.Addition();
                    break;

                case "subtracted":
                    actualResult = calculator.Subtraction();
                    break;

                case "multiplied":
                    actualResult = calculator.Multiplication();
                    break;

                case "divided":
                    actualResult = calculator.Division();
                    break;
            }
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}