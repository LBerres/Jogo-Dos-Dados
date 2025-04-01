namespace JogoDosDados.ConsoleApp
{
    /*
     * Versão 2 - Controle da Posição do Jogador e Vitória.
        Requisitos:

        Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado
        Exibir a posição atual do jogador na pista
        Definir a linha de chegada em 30 verificar se o jogador alcançou ou ultrapassou a linha de chegada
        Permitir o jogador realizar várias jogadas
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegada = 30;

            while (true)
            {
                int posicaoUsuario = 0;
                bool jogoEstaEmAndamento = true;

                while (jogoEstaEmAndamento)
                {
                    MenuInicial();

                    int resultado = LançamentoDoDado();

                    ExibirResultadoSorteio(resultado);

                    posicaoUsuario += resultado;

                    Console.WriteLine($"O Jogador Está Na Posição: {posicaoUsuario} de {limiteLinhaChegada}");

                    if (posicaoUsuario >= limiteLinhaChegada)
                    {
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                      Parabéns! Você Chegou Na Linha de Chegada!                                        ");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

                        jogoEstaEmAndamento = false;
                    }
                    else
                        Console.WriteLine($"O Jogador Está Na Posição: {posicaoUsuario} de {limiteLinhaChegada}");

                    Console.Write("Pressione ENTER Para Continuar.....");
                    Console.ReadLine();
                }

                string opcaoContinuar = MenuFinal();
                if (opcaoContinuar != "S")
                    break;
            }
        }
        static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                    Jogo dos Dados                                                      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Pressione ENTER Para Lançar o Dado.....");
            Console.ReadLine();
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
            Console.WriteLine($"                                      O Valor Sorteado Foi: {resultado}                                                ");
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
