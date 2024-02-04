using System;
namespace WithFactoryDesignPattern.Classes
{
    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "PLatinum Plus";
        }

        public int GetCreaditLimit()
        {
            return 2000;
        }
    }
}

