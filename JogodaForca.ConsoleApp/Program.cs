namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("_______________________________________________");

            //Solicita que o jogador digite um letra
            Console.Write("Digite uma letra válida: ");
            string entradainicial = Console.ReadLine(); // abacaxi

            if( entradainicial.Length > 1)
                       
            {
                Console.WriteLine("Informe apenas um caracter: ");
                return;
            }

            char chute = entradainicial[0];

            Console.WriteLine(entradainicial);


            //essa letra precisa ser avaliada pelo computador para ver se esta na palavra
            Console.ReadLine();


        }
    }
}                   














