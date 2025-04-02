namespace JogoDosDados.ConsoleApp
{
    /*
     * Versão 3 - Incluir o Computador Como Oponente. 
        Requisitos:

        Informar que o computador está jogando
        Armazenar a posição do computador na pista e atualizar o valor após o lançamento do dado
        Atualizar a posição do computador após seu lançamento de dado
        Exibir a nova posição
        Verificar se o computador alcançou ou ultrapassou a linha de chegada
        Informar quem venceu o jogo
        Implementar turnos alternados entre jogador e computador
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                int posicaoComputador = 0;
                bool jogoEstaEmAndamento = true;

                while (jogoEstaEmAndamento)
                {
                    // Turno do Usuário

                    MenuInicial("Usuário");

                    int resultado = LançamentoDoDado();

                    ExibirResultadoSorteio(resultado);

                    posicaoUsuario += resultado;

                    if (posicaoUsuario >= limiteLinhaChegada)
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                      Parabéns! Você Chegou Na Linha de Chegada!                                        ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                        Console.ReadLine();
                        jogoEstaEmAndamento = false;
                        continue;
                    }
                    else
                        Console.WriteLine($"O Jogador Está Na Posição: {posicaoUsuario} de {limiteLinhaChegada}");

                    Console.Write("Pressione ENTER Para Continuar.....");
                    Console.ReadLine();

                    // Turno do Computador

                    MenuInicial("Computador");

                    int resultadoComputador = LançamentoDoDado();

                    ExibirResultadoSorteio(resultadoComputador);

                    posicaoComputador += resultadoComputador;

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                  Que Pena! O Computador Chegou Na Linha de Chegada!                                    ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                        Console.ReadLine();
                        jogoEstaEmAndamento = false;
                        continue;
                    }
                    else
                        Console.WriteLine($"O Computador Está Na Posição: {posicaoComputador} de {limiteLinhaChegada}");

                    Console.Write("Pressione ENTER Para Continuar.....");
                    Console.ReadLine();
                }

                string opcaoContinuar = MenuFinal();
                if (opcaoContinuar != "S")
                    break;
            }
        }
        static void MenuInicial(string nomeJogador)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    Jogo dos Dados                                                      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"                                                 Turno do(a): {nomeJogador}                                            ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            if (nomeJogador != "Computador")
            {
                Console.Write("Pressione ENTER para lançar o dado...");
                Console.ReadLine();
            }
        }

        static int LançamentoDoDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;

        }

        static void ExibirResultadoSorteio(int resultado)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"                                                O Valor Sorteado Foi: {resultado}                                      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

        }

        static string MenuFinal()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("                                                Deseja Continuar? (S/N):                                                    ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }
    }
}
