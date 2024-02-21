using System;


namespace Homework2 {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Input the nominal of the trade:");
            string userInputNom = Console.ReadLine();
            int nominal = Int32.Parse(userInputNom);

            Console.WriteLine("Input the price of the trade:");
            string userInputPrice = Console.ReadLine();
            int price = Int32.Parse(userInputPrice);

            Console.WriteLine("Input the original price of the trade:");
            string userInputPriceOrigin = Console.ReadLine();
            int priceOrigin = Int32.Parse(userInputPriceOrigin);

            Console.WriteLine("Input the transaction code of the trade:");
            TransactionType trcType;
            string userInputTrans = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInputTrans, true);

            int sign = trcType == TransactionType.Buy ? 1 : -1;
            int factor = trcType == TransactionType.Buy ? 0 : 1;
            int curVal = sign * nominal * price;

            Console.WriteLine($"Current value ={curVal}");

            int pL = (price - priceOrigin) * nominal * factor;
            Console.WriteLine($"PL equals {pL}");

            Console.ReadKey();
        }
    }
}
