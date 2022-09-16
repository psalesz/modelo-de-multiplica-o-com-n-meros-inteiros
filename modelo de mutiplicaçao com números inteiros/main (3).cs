using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite o primeiro número para ser multiplicado:");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite o segundo número para ser multiplicado e realizar o calculo:");
        int n2 = int.Parse(Console.ReadLine());
        
        int conta;
        conta = (n1 * n2);
        
        while (n2 > 10) {
        Console.WriteLine("Digite um número válido");
        n2 = int.Parse(Console.ReadLine());
        }
        
        if (n2 <= 10) {
        conta = (n1 * n2);
        }
        Console.WriteLine(n1 + " X " + n2 + " = " + conta);
    }
}