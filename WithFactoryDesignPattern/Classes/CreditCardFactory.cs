using System;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace WithFactoryDesignPattern.Classes
{

//Now, the client needs to get the object through CreditCardFactory.For example, if the client wants to create an instance of a Platinum card,
//he/ she needs to do something like the below.As you can see, he/ she needs to pass the Credit card type to the GetCreditcard method of the CreditCardFactory class.
//Now, the GetCreditcard() method will create a Platinum class instance and return that instance to the client

public class CreditCardFactory
	{
        public static CreditCard GetCreditCard(String cardType)
        {

            CreditCard cardDetails = null;

            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();

            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();

            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;

        }   
	}
}

