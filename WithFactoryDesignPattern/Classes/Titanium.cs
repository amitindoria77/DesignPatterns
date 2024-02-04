using System;
namespace WithFactoryDesignPattern.Classes
{
	public class Titanium : CreditCard
	{
		public Titanium()
		{
		}

        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreaditLimit()
        {
            return 25000;
        }
    }
}

