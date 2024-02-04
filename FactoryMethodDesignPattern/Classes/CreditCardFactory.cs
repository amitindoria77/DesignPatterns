using System;
namespace FactoryMethodDesignPattern.Classes
{
    // The CreditCardFactory Creator class declares the factory method 
    // that is going to return an object of a Product class. 
    // The CreditCardFactory subclasses usually provide the implementation of the MakeProduct method.

    //Abstarct Class
    public abstract class CreditCardFactory
    {
        //* Abstarct Method
        protected abstract CreditCard MakeProduct();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method.



        // Concrete Method
        public CreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            CreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }

    //According to Gang of Four, we must define an interface or abstract class for creating an object. In our example, it is an abstract class, i.e., the CreditCardFactory class.
    //The second part of the definition says that let the subclasses decide which class to instantiate.
    //In our example, the subclasses are PlatinumFactory, MoneyBackFactory, and TitaniumFactory.
    //These subclasses will decide which class to instantiate, for example, MoneyBack, Titanium, and Platinum.


}

