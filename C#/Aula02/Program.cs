// See https://aka.ms/new-console-template for more information
using System;
namespace Aula02{
    class Program{
        static void Main(String[] args){
            Console.WriteLine("Ola Mundo!!");
            if(args.GetLength(0)>0){
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}