using System;
using System.Collections.Generic;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> resposta = new List<string>();
            Console.WriteLine("Sexo? 1.Homen 2.Mulher");
            resposta.Add(Console.ReadLine());
            Console.WriteLine("Usa Oculos? 1.Sim 2.Não");
            resposta.Add(Console.ReadLine());
            Console.WriteLine("Cabelos Cacheados? 1.Sim 2.Não");
            resposta.Add(Console.ReadLine());
            Console.WriteLine("Cabelos Vermelhos? 1.Sim 2.Não");
            resposta.Add(Console.ReadLine());
            string x;
            x = resposta[0] == "1" ? "É Tadeu" : "É uma das meninas";
            Console.WriteLine(x);
            x = resposta[0] == "2" && resposta[1] == "1" && resposta[2] == "2" && resposta[3] == "1" ? "É a Thamirys" : "Não é a Thamirys";
            Console.WriteLine(x);
            x = resposta[0] == "2" && resposta[1] == "2" && resposta[2] == "1" && resposta[3] == "2" ? "É a gil" : "Não é a Gil";
            Console.WriteLine(x);
            x = resposta[0] == "2" && resposta[1] == "2" && resposta[2] == "2" && resposta[3] == "1" ? "É a Thaise" : "Não é a Thaise";
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

