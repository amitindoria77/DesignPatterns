using System;
using System.Collections.Generic;
using System.Diagnostics;
using WithoutFactoryDesginPattern.Classes;

namespace WithoutFactoryDesginPattern
{
	public class Program
	{
		static void Main(String[] args)
		{
			//Usually we create credit card type from UI
			// Here we are hard coding the crad type

			string cardType = "MoneyBack";


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

		    if (cardDetails != null)
			{
				Console.WriteLine("CardType :" + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit :" + cardDetails.GetCreaditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
			else
			{
                Console.WriteLine("Invalid Card Type :");
            }

			Console.ReadLine();

            //The above code implementation introduces the following problems

            //First, the Tight Coupling between the client class (Program) and Product Classes(MoneyBack, Titanium, and Platinum).
			//So, when we make changes in one class, we must also make changes in the other classes.

            //Secondly, suppose we add a new Credit Card.In that case, we also need to modify the client code, i.e.,
			//the main method of the Program class, by adding an extra IF-ELSE Condition, which not only overheads the development but also the testing process.


        }
}
}

