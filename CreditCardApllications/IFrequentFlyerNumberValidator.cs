using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardApllications
{
    public interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frenquentFlyerNumber, out bool isValid);
    }
}
