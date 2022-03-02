using System;
using TechTalk.SpecFlow;
using RomanizingLibrary;

namespace TestingRomanizing.Features

{
    [Binding]

    public class RomanizingSteps
    {
        private readonly ScenarioContext context;
        public RomanizingSteps(ScenarioContext context)
        {
            this.context = context;
        }

        [Given(@"input of (.*)")]
        public void GivenInputOf(int p0)
        {
            context.Add("number", p0);
        }

        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            Program m = new();
            try 
            {
            var res = m.convertRoman(context.Get<int>("number"));
            context.Add("daAnswer", res);
            }
            catch
            {
                context.Add("exception caught", "True");
            }

        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string p0)
        {
            context.Get<string>("daAnswer").Should().Be(p0);
        }

        [Then(@"HeberSaid an ExceptionWasThrown")]
        public void ThenHeberSaidAnExceptionWasThrown()
        {
            context.Get<string>("exception caught").Should().Be("True");
        }
        [Then(@"the result will be blank")]
        public void ThenTheResultWillBeBlank()
        {
            context.Get<string>("daAnswer").Should().Be("");
        }

    }
}

