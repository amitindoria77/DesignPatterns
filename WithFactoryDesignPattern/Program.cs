using System;
using WithFactoryDesignPattern.Classes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WithFactoryDesignPattern
{

    //Using Factory Class (Credit Card Factory) in Client Code to Get the Product Instance

    //As you can see, now we are not creating the Product instance using IF-ELSE Condition; instead,
    //we are calling the Static GetCreditCard method of the CreditCardFactory class by passing the Credit Card Type which instance we need to create.
    //Once the GetCreditCard method returns the appropriate product instance, we consume the methods as it is. Here, we are storing the object in the super interface GetCreditCard.

    class Program
    {

        static void Main(string[] args)
        {


            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");


            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreaditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

            //Uml Diagram
            //https://dotnettutorials.net/wp-content/uploads/2018/11/Factory-Design-Pattern-UML-Diagram.png?ezimgfmt=ng:webp/ngcb8

            //Product Interface / Abstract Product: This represents the interface or abstract class defining the methods that concrete products must implement.In our example, it is the CreditCard Interface.
            //Concrete Products: These are the classes that implement the Product interface or extend the abstract class. They are the actual objects that the factory will create.In our example, it is the MoneyBack, Platinum, and Titanium classes.
            //Creator or Factory: This class provides the factory method to return an instance of a specific Concrete Product.In our example, it is the CreditCardFactory class.
            //Client: The class which is going to consume the actual product objects.In our example, it is the Program class Main method.

            //real example, a car factory can produce different types of cars. If you order a car based on your requirements or specifications, the factory will create the appropriate car and then deliver that car to you.



           //**  Problems of Simple Factory Pattern in C#

          //If we need to add any new product(i.e., a new credit card), then we need to add a new if else condition in the GetCreditCard method of the CreditCardFactory class. This violates the open/closed design principle.
          //We also have a tight coupling between the Factory(CreditCardFactory) and Product classes(MoneyBack, Titanium, and Platinum). We can overcome these problems using the Factory Method Design Pattern, which we will discuss in our upcoming articles.


        }
    }
}