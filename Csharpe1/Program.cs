using System;
namespace Csharpe1{
    class Program{
        static void Main(string [] args){
            var primeOrNot = new PrimeOrNot.ToCheckPrime();
            int input = Convert.ToInt32(Console.ReadLine());
            Console.Write(primeOrNot.isPrime(input));
        }
    }
}