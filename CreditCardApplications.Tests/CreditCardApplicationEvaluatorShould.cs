using CreditCardApllications;
using System;
using Xunit;

namespace CreditCardApplications.Tests
{
    public class CreditCardApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighIncomeApplications()
        {
            var sut = new CreditCardApplicationEvaluator();
            var application = new CreditCardApllication { GrossAnnualIncome = 100_000 };
            CreditApllicationDecision decision = sut.Evaluate(application);

            Assert.Equal(CreditApllicationDecision.AutoAccepted, decision);
        }
        [Fact]
        public void ReferYoungApplications()
        {
            var sut = new CreditCardApplicationEvaluator();
            var application = new CreditCardApllication { Age =  19};
            CreditApllicationDecision decision = sut.Evaluate(application);
            Assert.Equal(CreditApllicationDecision.ReferredToHuman, decision);

        }
    }
}
