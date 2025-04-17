namespace JogoDosDados.ConsoleApp
{
    /*
     * Versão 4 - Desafios (Avanço Extra, Recuo e Rodada Extra)
        Requisitos:
        Para tornar o jogo mais interessante, algumas posições na pista podem ter eventos especiais:

        ○ Avanço extra: Se o competidor parar em uma posição específica (ex.: 5, 10, 15), ele avança +3 casas.
        ○ Recuo: Se o competidor parar em outra posição específica (ex.: 7, 13, 20), ele recua -2 casas.
        ○ Rodada extra: Se o competidor tirar 6 no dado, ele ganha uma rodada extra.
     */

    internal class Program
    {
        static int limiteLinhaChegada = 30;
        static int posicaoUsuario = 0;
        static int posicaoComputador = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                bool jogoEstaEmAndamento = true;
                posicaoUsuario = 0;
                posicaoComputador = 0;


                while (jogoEstaEmAndamento)
                {
                    bool usuárioVenceu = ExecutarRodadaDoUsuário();

                    if (usuárioVenceu == true)
                    {
                        jogoEstaEmAndamento = false;
                        break;
                    }

                    Console.WriteLine();
                    Console.Write("                                          ...Pressione ENTER Para Continuar...");
                    Console.ReadLine();

                    bool computadorVenceu = ExecutarRodadaDoComputador();

                    if (computadorVenceu == true)
                    {
                        jogoEstaEmAndamento = false;
                        break;
                    }

                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("                                          ...Pressione ENTER Para Continuar...");
                    Console.ReadLine();
                }

                string opcaoContinuar = MenuFinal();
                if (opcaoContinuar != "S")
                    continue;
            }
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

        static bool ExecutarRodadaDoUsuário()
        {
            bool turnoExtraDoUsuario = true;
            bool usuarioVenceu = false;
            
            do
            {
                turnoExtraDoUsuario = false;

                MenuInicial("Usuário(a)", posicaoUsuario, posicaoComputador, limiteLinhaChegada);

                int resultado = LançamentoDoDado();

                ExibirResultadoSorteio(resultado);

                posicaoUsuario += resultado;

                if (posicaoUsuario >= limiteLinhaChegada)
                {
                    Console.Clear();
                    MenuInicial("Usuário(a)", posicaoUsuario, posicaoComputador, limiteLinhaChegada);
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("                                    ...Parabéns! Você Chegou Na Linha de Chegada!...");
                    Console.ReadLine();

                    usuarioVenceu = true;
                    break;
                }


                // Casas Especiais
                else if (resultado == 6)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("                                  !Você Rolou Um Acerto Crítico, Ganha mais uma Rodada!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                    turnoExtraDoUsuario = true;
                }

                else if (posicaoUsuario == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                        Você Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }
                else if (posicaoUsuario == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                        Você Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }

                else if (posicaoUsuario == 15)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                        Você Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }

                else if (posicaoUsuario == 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                       Você Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else if (posicaoUsuario == 13)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                       Você Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else if (posicaoUsuario == 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                       Você Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                           O Jogador Está na Posição: {posicaoUsuario} de {limiteLinhaChegada}");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }

            } while (turnoExtraDoUsuario);

            return usuarioVenceu;
        }

        static bool ExecutarRodadaDoComputador()
        {
            bool turnoExtraDoComputador = true;
            bool computadorVenceu = false;
            
            do
            {
                turnoExtraDoComputador = false;

                MenuInicial("Computador", posicaoUsuario, posicaoComputador, limiteLinhaChegada);

                int resultado = LançamentoDoDado();

                ExibirResultadoSorteio(resultado);

                posicaoComputador += resultado;

                if (posicaoComputador >= limiteLinhaChegada)
                {
                    Console.Clear();
                    MenuInicial("Computador", posicaoUsuario, posicaoComputador, limiteLinhaChegada);
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
                    Console.WriteLine($"                                         O Computador Está na Posição: {posicaoComputador} de {limiteLinhaChegada}");
                    Console.WriteLine();
                }

            } while (turnoExtraDoComputador);

            return computadorVenceu;
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
