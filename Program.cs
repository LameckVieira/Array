using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            string [] nomes =  new string[1];
            int[] idade = new int[1];

            for (var contador = 0; contador < 1; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idade[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nomes Cadastrados:");
            
            for(var contador = 0; contador < 1; contador++){
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.WriteLine("Idade: "+idade[contador]);

            }
                

        }
    }
}
