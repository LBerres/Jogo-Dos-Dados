namespace JogoDosDados.ConsoleApp
{
    /*
     * Versão 1 - Estrutura Básica e Simulação de Dados 
        Requisitos:
        Exibir um banner para o jogo de dados
        Implementar a geração de números aleatórios para simular um dado (1-6)
        Exibir o resultado do lançamento do dado
        Permitir que o usuário pressione Enter para lançar o dado
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                MenuInicial();

                int resultado = LançamentoDoDado();

                ExibirResultadoSorteio(resultado);

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
            Console.Write("Deseja Continuar? (S/N): ");
            string opcaoContinuar = Console.ReadLine().ToLower();

            return opcaoContinuar;
        }
    }
}
