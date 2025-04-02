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
                    bool turnoDoUsuario = true;

                    while (turnoDoUsuario)
                    {
                        MenuInicial("Usuário(a)", posicaoUsuario, posicaoComputador, limiteLinhaChegada);

                        int resultado = LançamentoDoDado();

                        ExibirResultadoSorteio(resultado);

                        posicaoUsuario += resultado;

                        if (resultado == 6)
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                !Você Rolou Um Acerto Crítico, Ganha mais uma Rodada!                                   ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.ReadLine();
                            continue;
                        }

                        // Casas Especiais
                        else if (posicaoUsuario == 5)
                        {
                            Console.WriteLine("                                       Você Encontrou Um Atalho! Avance 3 Casas!                                        ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario += 3;
                        }
                        else if (posicaoUsuario == 10)
                        {
                            Console.WriteLine("                                       Você Encontrou Um Atalho! Avance 3 Casas!                                        ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario += 3;
                        }

                        else if (posicaoUsuario == 15)
                        {
                            Console.WriteLine("                                       Você Encontrou Um Atalho! Avance 3 Casas!                                        ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario += 3;
                        }

                        else if (posicaoUsuario == 7)
                        {
                            Console.WriteLine("                                      Você Encontrou Um Obstáculo! Volte 2 Casas!                                       ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario -= 2;
                        }

                        else if (posicaoUsuario == 13)
                        {
                            Console.WriteLine("                                      Você Encontrou Um Obstáculo! Volte 2 Casas!                                       ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario -= 2;
                        }

                        else if (posicaoUsuario == 20)
                        {
                            Console.WriteLine("                                      Você Encontrou Um Obstáculo! Volte 2 Casas!                                       ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoUsuario -= 2;
                        }

                        // Linha de Chegada
                        else if (posicaoUsuario >= limiteLinhaChegada)
                        {
                            Console.Clear();
                            MenuInicial("Usuário(a)", posicaoUsuario, posicaoComputador, limiteLinhaChegada);
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                      Parabéns! Você Chegou Na Linha de Chegada!                                        ");

                            Console.ReadLine();
                            jogoEstaEmAndamento = false;
                            break;                            
                        }
                        else if (posicaoUsuario <= limiteLinhaChegada)
                        {
                            Console.Write("Pressione ENTER Para Continuar.....");
                            Console.ReadLine();
                        }

                        else
                            turnoDoUsuario = false;
                            break;
                        
                    }
                 if (jogoEstaEmAndamento == false)
                 
                        break;
                    
                    bool turnoDoComputador = true;

                    while (turnoDoComputador)
                    {
                        MenuInicial("Computador", posicaoUsuario, posicaoComputador, limiteLinhaChegada);

                        int resultadoComputador = LançamentoDoDado();

                        ExibirResultadoSorteio(resultadoComputador);

                        posicaoComputador += resultadoComputador;
                        
                        if (resultadoComputador == 6)
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                              !Computador Rolou Um Acerto Crítico, Ganha mais uma Rodada!                               ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.ReadLine();
                            continue;
                        }

                        // Casas Especiais
                        if (posicaoComputador == 5)
                        {
                            Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!                                     ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador += 3;
                        }
                        else if (posicaoComputador == 10)
                        {
                            Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!                                     ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador += 3;
                        }

                        else if (posicaoComputador == 15)
                        {
                            Console.WriteLine("                                   Computador Encontrou Um Atalho! Avançou 3 Casas!                                     ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador += 3;
                        }

                        else if (posicaoComputador == 7)
                        {
                            Console.WriteLine("                                  Computador Encontrou Um Obstáculo! Voltou 2 Casas!                                    ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador -= 2;
                        }

                        else if (posicaoComputador == 13)
                        {
                            Console.WriteLine("                                  Computador Encontrou Um Obstáculo! Voltou 2 Casas!                                    ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador -= 2;
                        }

                        else if (posicaoComputador == 20)
                        {
                            Console.WriteLine("                                  Computador Encontrou Um Obstáculo! Voltou 2 Casas!                                    ");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            posicaoComputador -= 2;
                        }

                        // Linha de Chegada

                        else if (posicaoComputador >= limiteLinhaChegada)
                        {
                            Console.Clear();
                            MenuInicial("Computador", posicaoUsuario, posicaoComputador, limiteLinhaChegada);
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                  Que Pena! O Computador Chegou Na Linha de Chegada!                                    ");

                            Console.ReadLine();
                            jogoEstaEmAndamento = false;
                            break;

                        }
                        else if (posicaoComputador <= limiteLinhaChegada)
                        {
                            Console.Write("Pressione ENTER Para Continuar.....");
                            Console.ReadLine();
                        }

                        else
                            turnoDoComputador = false;
                        break;
                    }

                    if (jogoEstaEmAndamento == false)

                        break;
                }

                string opcaoContinuar = MenuFinal();
                if (opcaoContinuar != "S")
                    break;
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
            Console.WriteLine($"                                                 Turno do: {nomeJogador}                                            ");
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
