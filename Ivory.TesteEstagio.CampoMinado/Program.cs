using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            Random random = new Random();
            int linha = 0;
            int coluna = 0;

            while (campoMinado.JogoStatus != 2)
            {
                try
                {
                    linha = int.Parse(Console.ReadLine());
                    coluna = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("\nVocê não digitou um número, repita novamente.");
                } finally {

                    campoMinado.Abrir(linha, coluna);
                }
            }

             while (campoMinado.JogoStatus != 2)
             {
                 System.Console.Write("\nDigite o número da linha: ");
                 int linha = int.Parse(Console.ReadLine());
                 System.Console.Write("Digite o número da coluna: ");
                 int coluna = int.Parse(Console.ReadLine());

                 campoMinado.Abrir(linha, coluna);
                 Console.WriteLine(campoMinado.Tabuleiro);
                 var pausa = Console.ReadKey();
                 Console.Clear();
             }

            if (campoMinado.JogoStatus == 1)
            {
                System.Console.WriteLine("\nMeus parabéns, você ganhou!");
            }
            else
            {
                Console.WriteLine(campoMinado.Tabuleiro);
                System.Console.WriteLine("\nVocê perdeu, tente da próxima vez!");
                System.Console.WriteLine("Quer tentar de novo?");

                int resposta = 0;

                while (resposta == 0)
                {
                    try
                    {
                        System.Console.Write("(1 - Sim / 2 - Não): ");
                        resposta = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        System.Console.WriteLine("\nVocê não digitou um número, repita novamente.");
                    }
                }

                if (resposta == 1)
                {
                    Console.Clear();
                    Program.Main(null);
                }
                else
                {
                    System.Console.WriteLine("------ FIM DE JOGO ------");
                    var pausa = Console.ReadKey();
                }
            }
        }
    }
}
