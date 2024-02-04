using System;
namespace FactoryMethodDesignPattern
{
	public interface CreditCard
	{
        string GetCardType();
        int GetCreaditLimit();
        int GetAnnualCharge();
    }
}

