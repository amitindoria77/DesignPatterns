using System;
namespace FactoryMethodDesignPattern.Classes
{
    // We have three credit cards Moneyback, Titanum and Platinum so need to create three seprate classes and implement the interface creditcard
	public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType() 
		{
			return "MoneyBack";
		}

        public int GetCreaditLimit()
        {
            return 15000;
        }
    }
}

