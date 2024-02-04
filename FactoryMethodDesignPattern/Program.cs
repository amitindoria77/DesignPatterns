using FactoryMethodDesignPattern;
using FactoryMethodDesignPattern.Classes;

class Program
{

    //1. Product: This is an interface for creating objects.Here, we need to define the Opeartions a Product should have. In our example, it is the CreditCard interface.
    //2. Concrete Product: This is a class that implements the Product interface. In our example, MoneyBack, Titanium, and Platinum classes are the Concrete Products.These classes implement the Product interface, i.e.CreditCard.
    //3. Abstract Creator: This is an abstract class and declares the factory method, which returns an object of type Product.
    //    In our example, the CreditCardFactory abstract class has the CreateProduct Factory method, which will create and return an instance of the actual product.
    //    Internally, this CreateProduct method will call the subclass MakeProduct method, creating and returning the appropriate product instance.
    //4. Concrete Creator: These classes implement the Abstract Creator class and override the factory method to return an instance of a Concrete Product.

    static void Main(string[] args)
    {
        // The client code works with an instance of a concrete creator
        // The CreateProduct will return the actual product instance via the product interface
        //PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
        CreditCard creditCard = new PlatinumFactory().CreateProduct();

        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreaditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
        Console.WriteLine("--------------");
        //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
        creditCard = new MoneyBackFactory().CreateProduct();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreaditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
        Console.ReadLine();
    }
}