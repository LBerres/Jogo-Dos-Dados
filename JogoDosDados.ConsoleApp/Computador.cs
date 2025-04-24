namespace JogoDosDados.ConsoleApp
{
    public class Computador
    {
        public static int posicaoComputador = 0;

        public static bool ExecutarRodadaDoComputador()
        {
            bool turnoExtraDoComputador = true;
            bool computadorVenceu = false;

            do
            {
                turnoExtraDoComputador = false;

                MenuInicial("Computador", Usuário.posicaoUsuario, posicaoComputador, Program.limiteLinhaChegada);

                int resultado = LançamentoDoDado();

                ExibirResultadoSorteio(resultado);

                posicaoComputador += resultado;

                if (posicaoComputador >= Program.limiteLinhaChegada)
                {
                    Console.Clear();
                    MenuInicial("Computador", Usuário.posicaoUsuario, posicaoComputador, Program.limiteLinhaChegada);
                    Console.WriteLine();
                    Console.WriteLine("                                ...Que Pena! O Computador Chegou Na Linha de Chegada!...");
                    Console.ReadLine();

                    computadorVenceu = true;
                    break;
                }

                // Casas Especiais
                else if (resultado == 6)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("                               !Computador Rolou Um Acerto Crítico, Ganha mais uma Rodada!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();

                    turnoExtraDoComputador = true;
                }

                else if (posicaoComputador == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    posicaoComputador += 3;
                }
                else if (posicaoComputador == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    posicaoComputador += 3;
                }

                else if (posicaoComputador == 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    posicaoComputador += 3;
                }

                else if (posicaoComputador == 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Obstáculo! Voltou 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoComputador -= 2;
                }

                else if (posicaoComputador == 13)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Obstáculo! Voltou 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoComputador -= 2;
                }

                else if (posicaoComputador == 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                   Computador Encontrou Um Obstáculo! Voltou 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoComputador -= 2;
                }


                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                         O Computador Está na Posição: {posicaoComputador} de {Program.limiteLinhaChegada}");
                    Console.WriteLine();
                }

            } while (turnoExtraDoComputador);

            return computadorVenceu;
        }

        static void MenuInicial(string nomeJogador, int posicaoUsuario, int posicaoComputador, int limiteLinhaChegada)
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    Jogo dos Dados                                                      ");
            Console.WriteLine("                         _________                    _________                _________                                ");
            Console.WriteLine("                        |         |                  |         |              | o  o  o |                               ");
            Console.WriteLine("                        |    o    |                  |    ?    |              | o  o  o |                               ");
            Console.WriteLine("                        |         |                  |         |              | o  o  o |                               ");
            Console.WriteLine("                         ---------                    ---------                ---------                                ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"O Usuário(a) Está Na Posição: {posicaoUsuario} de {limiteLinhaChegada}");
            Console.WriteLine($"O Computador Está Na Posição: {posicaoComputador} de {limiteLinhaChegada}");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"                                                 Turno do: {nomeJogador}                                            ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            if (nomeJogador != "Computador")
            {
                Console.Write("                                        ...Pressione ENTER Para Lançar o Dado...");
                Console.WriteLine();
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
            Console.WriteLine($"                                                O Valor Sorteado Foi: {resultado}                                      ");

        }

    }
}
