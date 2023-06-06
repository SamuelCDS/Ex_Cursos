using System;
class Aula12{
    static void Main(){
        int n1, n2, n3, n4, res = 0;
        string resultado = "Reprovado";

        Console.Write("Digita nota1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digita a n2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digita a n3: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digita a n4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1+n2+n3+n4;

        if (res >= 60){
            resultado = "Aprovado";
        }
        Console.WriteLine("Resultado: {0}", resultado);
    }
}