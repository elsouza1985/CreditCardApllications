using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApllications
{
    public class CreditCardApplicationEvaluator
    {
        private readonly IFrequentFlyerNumberValidator _validator;
        private const int AutoReferralMaxAge = 20;
        private const int HighIncomeThreshold = 100_000;
        private const int LowIncomeThreshold = 20_000;
        public CreditCardApplicationEvaluator(IFrequentFlyerNumberValidator validator)
        {
            _validator = validator;
        }
        public CreditApllicationDecision Evaluate(CreditCardApllication apllication)
        {
            if(apllication.GrossAnnualIncome >= HighIncomeThreshold)
            {
                return CreditApllicationDecision.AutoAccepted;
            }
            if(apllication.Age <=AutoReferralMaxAge)
            {
                return CreditApllicationDecision.ReferredToHuman;
            }
            if(apllication.GrossAnnualIncome< LowIncomeThreshold)
            {
                return CreditApllicationDecision.AutoDeclined;
            }
            return CreditApllicationDecision.ReferredToHuman;
        }
    }
}
