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
            Random rnd = new Random();
            int numJogada = 2,
                linha = 0,
                coluna = 0;

            // Bem, não consegui fazer a lógica, ainda falta conhecimento.
            // Estou no 2° período da faculdade e queria testar meus conhecimento.
            // A Ivory é uma empresa que tem o seu nome já bem registrado no mercado.
            // Foi muito bom participar desse processo seletivo, achei que nem iam me chamar.
            // Por causa do meu currículo, pois ainda sou somente estudante de faculdade.
            // Ainda não prestei nenhum estágio. Ainda me falta conhecimento em POO.
            // Saio desse processo aprendendo a jogar Campo Minado, e como é um processo seletivo de TI.
            // Com certeza queria saber muito como eu manipularia esse algoritmo.
            // No mais um muito obrigado, e segue embaixo o que eu consegui fazer.


            while (campoMinado.JogoStatus <= 1)
            {
                // Um loop com a decisão do jogador da linha e da coluna.
                Console.Write("Qual é a linha que você quer jogar? (De 1 a 9): ");
                linha = int.Parse(Console.ReadLine());
                Console.Write("Qual é a coluna que você quer jogar? (De 1 a 9): ");
                coluna = int.Parse(Console.ReadLine());

                // Método Abrir recebe essas variáveis, e adiciona na matriz Jogo
                campoMinado.Abrir(linha, coluna);
                // Somente para efeito visual um console em uma variável para retornar as jogadas.
                Console.Write($"\n--- {numJogada}° jogada ---");
                Console.WriteLine($"\n\n{campoMinado.Tabuleiro}");
                // Soma na variável numJogada para retornar uma nova "jogada".
                numJogada++;
            }

            // while (campoMinado.JogoStatus <= 1)
            // {
            //     // Um loop que pesquisa tanto linha quanto coluna, aleatóriamente. 

            //     campoMinado.Abrir(rnd.Next(1, 10), rnd.Next(1, 10));
            //     // Somente para efeito visual um console em uma variável para retornar as jogadas.
            //     Console.Write($"\n--- {numJogada}° jogada ---");
            //     Console.WriteLine($"\n\n{campoMinado.Tabuleiro}");
            //     // Soma na variável numJogada para retornar uma nova "jogada".
            //     numJogada++;
            // }

            switch (campoMinado.JogoStatus)
            {
                // Um teste feito somente, para ilustrar para o jogador, se ele teve vitória ou não em jogar.

                case 1:
                    Console.WriteLine("\nParabéns você venceu o jogo! :)");
                    break;
                case 2:
                    Console.WriteLine("\nQue pena, você perdeu! Se esforce mais da próxima vez! :(");
                    break;
            }
        }
    }
}
