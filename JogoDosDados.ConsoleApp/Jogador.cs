namespace JogoDosDados.ConsoleApp
{/*
  * Estruturação Orientada a Objetos
 */

    public class Jogador
    {
        int posicaoUsuario = 0;
        public string nome = "";

        public bool ExecutarRodada()
        {
            bool turnoExtraDoUsuario = true;
            bool usuarioVenceu = false;

            do
            {
                turnoExtraDoUsuario = false;

                MenuInicial(posicaoUsuario, Program.limiteLinhaChegada);

                int resultado = LançamentoDoDado();

                ExibirResultadoSorteio(resultado);

                posicaoUsuario += resultado;

                if (posicaoUsuario >= Program.limiteLinhaChegada)
                {
                    Console.Clear();
                    MenuInicial(posicaoUsuario, Program.limiteLinhaChegada);
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"                                    ...Parabéns! {nome} Chegou Na Linha de Chegada!...");
                    Console.ReadLine();

                    usuarioVenceu = true;
                    break;
                }


                // Casas Especiais
                else if (resultado == 6)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"                                  !{nome} Rolou Um Acerto Crítico, Ganha mais uma Rodada!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                    turnoExtraDoUsuario = true;
                }

                else if (posicaoUsuario == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                        {nome} Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }
                else if (posicaoUsuario == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                        {nome} Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }

                else if (posicaoUsuario == 15)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                        {nome} Encontrou Um Atalho! Avance 3 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario += 3;
                }

                else if (posicaoUsuario == 7)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                       {nome} Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else if (posicaoUsuario == 13)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                       {nome} Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else if (posicaoUsuario == 20)
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                       {nome} Encontrou Um Obstáculo! Volte 2 Casas!");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    posicaoUsuario -= 2;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"                                         O {nome} Está na Posição: {posicaoUsuario} de {Program.limiteLinhaChegada}");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }

            } while (turnoExtraDoUsuario);

            return usuarioVenceu;
        }

        void MenuInicial(int posicaoUsuario, int limiteLinhaChegada)
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
            Console.WriteLine();
            Console.WriteLine($"                                                 Turno do: {nome}                                            ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            if (nome != "Computador")
            {
                Console.Write("                                        ...Pressione ENTER Para Lançar o Dado...");
                Console.WriteLine();
                Console.ReadLine();
            }
        }

        int LançamentoDoDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;

        }

        void ExibirResultadoSorteio(int resultado)
        {
            Console.WriteLine($"                                                O Valor Sorteado Foi: {resultado}                                      ");

        }

    }
}
