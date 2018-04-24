using System;

namespace Programa_Comissao
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
            double valorMeta, perComissao, valorVenda, valorComissao;

            Console.Clear();

            Console.WriteLine("Olá, Bem Vindo a Calculadora de Comissão. <<<<< Digite os Valores Para Continuar >>>>>");
            Console.WriteLine("Digite Por Favor o Valor da Sua Meta");
            valorMeta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Percentual de Comissão");
            perComissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor da Venda");
            valorVenda = double.Parse(Console.ReadLine());

            if(valorVenda>=valorMeta)
                valorComissao = valorVenda*(perComissao/100);
            else
                valorComissao = 0;

            Console.WriteLine("O Valor da Comissão é: " + valorComissao);


       
       
       
        }




    }
}
