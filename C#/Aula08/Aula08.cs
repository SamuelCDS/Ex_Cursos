using System;
class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Soma: {0}", v1+v2);
    }
}
