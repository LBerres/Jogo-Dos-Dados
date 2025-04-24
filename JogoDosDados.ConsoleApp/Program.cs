namespace JogoDosDados.ConsoleApp
{/*
  * Estruturação Por Arquivos Estáticos e Classes
 */
    internal class Program
    {
        public static int limiteLinhaChegada = 30;

        static void Main(string[] args)
        {
            while (true)
            {
                bool jogoEstaEmAndamento = true;

                Jogador usuario = new Jogador();
                usuario.nome = "Usuário(a)";

                Jogador computador = new Jogador();
                computador.nome = "Computador";

                while (jogoEstaEmAndamento)
                {
                    bool usuárioVenceu = usuario.ExecutarRodada();

                    if (usuárioVenceu == true)
                    {
                        jogoEstaEmAndamento = false;
                        break;
                    }

                    Console.WriteLine();
                    Console.Write("                                          ...Pressione ENTER Para Continuar...");
                    Console.ReadLine();

                    bool computadorVenceu = computador.ExecutarRodada();

                    if (computadorVenceu == true)
                    {
                        jogoEstaEmAndamento = false;
                        break;
                    }

                    Console.WriteLine();
                    Console.Write("                                          ...Pressione ENTER Para Continuar...");
                    Console.ReadLine();
                }

                string opcaoContinuar = MenuFinal();
                if (opcaoContinuar == "S")
                    continue;
                else
                    break;
            }
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
