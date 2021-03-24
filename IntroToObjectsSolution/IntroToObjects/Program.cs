using System; //indicating a namespace


namespace IntroToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a variable
            //datatype and name
            //optionally you can assign a value to the variable as it is created.
            string inputTemp = null;

            //what about developer defined datatypes
            //the class name is used as the datatype
            //
            //declaring a variable of the developer datattype class
            //  sets aside a phyiscal area in memory to hold the
            //  address location of the actual instance of the class
            //default of these variables is null
            Wallet myWallet = null;

            //how does one get an instance (occurance) of my class
            //the instance is referred to as the object
            //the instance is a physical thing
            //the new command executes the constructor of your class

            myWallet = new Wallet(); //signature of the Default constructor

            Console.WriteLine($"cash {myWallet.CashBills + myWallet.CashCoins}");

            Wallet herWallet = new Wallet();

            //changing a value in an existing instance
            //since the property is on the left side of the assignment statement
            //  the property mutator (set{..}) will be executed
            herWallet.CashCoins = 3.75;

            Console.WriteLine($"cash {herWallet.CashBills + herWallet.CashCoins}");

            //signature of the Greedy constructor

            Wallet hisWallet = new Wallet(10, 2, "ADDR1234", null, null, null);

            Console.WriteLine($"cash {hisWallet.CashBills + hisWallet.CashCoins}");

            //assigning a value to my instance using the property
            //the instance is on the left side of an assignment statement
            //property is using the "set" 
            myWallet.CashCoins = 13;

            //access to the instance is using properties
            //the instance is on the right side of an assignment statement
            //property is using the "get"
            double addedNumbers = myWallet.CashBills + myWallet.CashCoins;

            Console.WriteLine($"cash {addedNumbers}");

            //object initializers
            //will use the default constructor to create the instance
            //  THEN it assigns values to the data storage in the instance
            //  via a coding block
            //NOTE: could also be new Wallet() { ....}
            Wallet myInitializedWallet = new Wallet
            { 
                //BankCard = null, //null is the default value for a string
                CashBills = 25.00, //using the set of the property CashBills
                CashCoins = 2.00,
                GasCard = "123456"
            };

            Console.WriteLine($"cash {myInitializedWallet.CashBills + myInitializedWallet.CashCoins}");

            Console.WriteLine($"Cards Bank: {myInitializedWallet.BankCard} Gas:  {myInitializedWallet.GasCard} Visa: {myInitializedWallet.VisaCard}" );


            //using the class behaviour (method)
            //the method returns a bool (true or false)
            //REMEMBER, your conditions resolve to either true or false
            //  true == true resolves to true, WHY code the condition?
            //  false == true resolves to false, WHY code the condition?

            double insufficent = 4.25;
            double sufficent = 2.75;
            if(herWallet.ExtractAmount(sufficent))
            {
                Console.WriteLine($"Sufficent coins, new coin amount: {herWallet.CashCoins}");
            }
            else
            {
                Console.WriteLine($"Insufficent coins, coin amount: {herWallet.CashCoins}. Use bills and get your change back.");
            }
        }
    }
}
