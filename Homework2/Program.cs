﻿using System;


namespace Homework2 {

    enum TransactionType { Buy, Sell }

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Input the nominal of the trade:");
            string userInputNom = Console.ReadLine();
            int nominal = Int32.Parse(userInputNom);

            Console.WriteLine("Input the price of the trade:");
            string userInputPrice = Console.ReadLine();
            int price = Int32.Parse(userInputPrice);

            Console.WriteLine("Input the transaction code of the trade:");
            TransactionType trcType;
            string  userInputTrans = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInputTrans, true);

            int sign = trcType == TransactionType.Buy ? 1 : -1;

            int curVal = sign * nominal * price;

            Console.WriteLine($"Current value ={curVal}");

            Console.ReadKey();
        }
    }
}
