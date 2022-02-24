using System;

namespace EsquerdaVolver.Consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Comandos;

            char sentido = 'N';

            Console.WriteLine("Direita Volver");

            Console.WriteLine("Digite a quantidade de Comandos:  ");

            int numerosComandos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Comandos:  ");

            Comandos = Console.ReadLine();


            char[] instrucao = Comandos.ToCharArray();


            for (int i = 0; i < numerosComandos; i++)

            {
                if (instrucao[i] == 'E')
                {


                    if (sentido == 'N') sentido = 'O';

                    else if (sentido == 'S') sentido = 'L';

                    else if (sentido == 'O') sentido = 'S';

                    else if (sentido == 'L') sentido = 'N';


                }

                if (instrucao[i] == 'D')
                {


                    if (sentido == 'N') sentido = 'L';

                   else if (sentido == 'S') sentido = 'O';

                   else if (sentido == 'O') sentido = 'N';

                    else if(sentido == 'L') sentido = 'S';


                }

            }


            Console.WriteLine("Sentido Final: " + sentido);

        }
    }
}
