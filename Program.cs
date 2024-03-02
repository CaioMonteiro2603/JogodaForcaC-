namespace JogodaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ChancesDoJogador, i, acertos;
            string palavraDigitada;
            char letra;
            string palavraEscondida = string.Empty;
            bool acertou = true; 
            ChancesDoJogador = 4;
            acertos = 0;

            Console.WriteLine("Jogo da Forca! Peça para seu amigo tapar os olhos e digite uma palavra abaixo: ");
            palavraDigitada = Console.ReadLine().ToLower();
            Console.Clear(); 
            if(palavraDigitada == string.Empty )
            {
                Console.WriteLine("caixa de texto vazia!"); 
            }

            for(i = 0; i < palavraDigitada.Length; i++)
            {
                palavraEscondida += '-'; 
            }

            while(ChancesDoJogador > 0 && acertos < palavraDigitada.Length)
            {
                Console.WriteLine("Chances restantes: " + ChancesDoJogador);
                Console.WriteLine("Palavra do jogo: " + palavraEscondida);

                Console.WriteLine("Digite uma letra: ");
                letra = Convert.ToChar(Console.ReadLine());
                Console.Clear(); 

                for(i = 0; i < palavraDigitada.Length; i++)
                {
                    if(letra == palavraDigitada[i])
                    {
                        acertou = true; 
                        palavraEscondida = palavraEscondida.Remove(i, 1).Insert(i, letra.ToString()); 
                        acertos++;
                    }
                }

                if(!acertou)
                {
                    ChancesDoJogador--;
                }
                acertou = false; 

            }

            if(acertos == palavraDigitada.Length)
            {
                Console.WriteLine("Parabéns, você ganhou!");
            } else
            {
                Console.WriteLine("Que pena, você perdeu"); 
            }
        }
    }
}
