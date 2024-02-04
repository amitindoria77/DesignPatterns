using System;
namespace WithFactoryDesignPattern
{
	// Here we can create a interface or a absract class
	public interface CreditCard
	{

		string GetCardType();
		int GetCreaditLimit();
		int GetAnnualCharge();
	}
}

