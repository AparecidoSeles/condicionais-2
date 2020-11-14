using System;

namespace condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Console.writeline) exibe o texto na tela
            //(parse) converter qualquuer variável em texto
            //(int) variável so aceita valores numéricos
            //(string) variável so aceita letras

            Console.WriteLine("Qual sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=18){  // abre se uma cahve quando tem uma condiçaõ de verdadeiro ou falso
                Console.WriteLine("Você gostaria de participar do time de CS GO? - Sim ou Não?");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Comaparecer a secretaria - Falar com SARA");
                }else{
                    Console.WriteLine("Blz! Passar bem");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do time de lol? Sim ou Não? ");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Comparecer a secretaria - Falar com Jucelino");
                }else{
                    Console.WriteLine("Mioto Obrigado!");
                }
            }
        }
    }
}
