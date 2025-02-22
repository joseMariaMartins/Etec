using System;
using System.Threading;
using static System.Console;//não precisa ficar escrevendo console

namespace BRUNOHENRIQUE

{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;

            ForegroundColor = ConsoleColor.DarkBlue;
            BackgroundColor = ConsoleColor.Black;
            do
            { //faca()
                Clear();

                SetCursorPosition(30, 0);
                WriteLine("*** Menu Principal ***");

                SetCursorPosition(25, 4);
                WriteLine("[1] Par Impar");

                SetCursorPosition(25, 5);
                WriteLine("[2] calcuos especificos");

                SetCursorPosition(25, 6);
                WriteLine("[3] adivinhar");

                SetCursorPosition(25, 7);
                WriteLine("[4] sorteia_nomes");

                SetCursorPosition(25, 8);
                WriteLine("[5] babo");

                SetCursorPosition(25, 9);
                WriteLine("[6] zeira");

                SetCursorPosition(25, 10);
                WriteLine("[7] zenit sinuzite");

                SetCursorPosition(25, 11);
                WriteLine("[8] Fim");

                SetCursorPosition(0, 12); Write(new string('*', 100));

                SetCursorPosition(25, 13); Write("Digite sua opção:");

                SetCursorPosition(43, 13);
                opc = int.Parse(ReadLine());
                switch (opc)
                {
                    case 1:
                        Par_impar();
                        break;
                    case 2:
                        //calculos_esp();
                        break;
                    case 3:
                        adivinhar();
                        break;
                    case 4:
                        sorteia_nomes();
                        break;
                    case 5:

                        break;
                    case 6:
                        duplas();
                        break;
                    case 7:
                        conta_letra();
                        break;
                    default:
                        break;

                }
            } while (opc != 8);
        }
        static void Par_impar()
        {
            string vresp = "";
            int n;
            do
            {


                Clear();
                SetCursorPosition(25, 10);
                Write("digite um numero: ");
                n = int.Parse(ReadLine());
                SetCursorPosition(25, 12);
                if (n % 2 == 0)
                {
                    Write($"{n} é par");
                }
                else //senao
                {
                    Write($"{n} é impar");
                }
                Thread.Sleep(2000);

                Clear();
                SetCursorPosition(37, 14);
                Write("Deseja continuar? (s/n)");
                vresp = ReadLine();
            } while (vresp.ToLower() == "s");//não sei fazer
        }
        static void adivinhar()
        {
            Random geranum = new Random();
            int NS, n, tentativas;
            string vresp = "";
            Clear();

            NS = geranum.Next(1, 11);//1-10

            do
            {
                do
                {

                    Clear();
                    Write("Digite seu palpite");
                    tentativas = 0;
                    tentativas++;
                    n = int.Parse(ReadLine());//leia(n)
                    if (n > NS)
                    {
                        SetCursorPosition(25, 20);
                        Write($" {tentativas}° --> é maior que o numero sorteado...");
                        SetCursorPosition(25, 20);
                        Thread.Sleep(2000);
                    }
                    else if (n < NS)
                    {
                        SetCursorPosition(25, 20);
                        Write($" {tentativas}° --> é menor que o numero sorteado...");
                        SetCursorPosition(25, 20);
                        Thread.Sleep(2000);

                    }
                    else
                    {
                        SetCursorPosition(25, 20);
                        Write("Parabens, voce acertou!!!");
                        Thread.Sleep(2000);
                    }
                } while (n != NS);
                Clear();
                SetCursorPosition(37, 14);
                Write("Deseja continuar? (s/n)");
                vresp = ReadLine();
            } while (vresp.ToLower() == "s");
        }
        static void sorteia_nomes()
        {
            string nomes, vresp = "";
            Random gn = new Random();
            int i, ns, vtam;
            Clear();
            WriteLine("Informe uma lista de nomes separado por virgulas: ");
            nomes = ReadLine();

            String[] nome = nomes.Split(',');
            vtam = nome.Length;
            Write("");
            do
            {
                for (i = 0; i < nome.Length; i++)
                {
                    WriteLine($"{i + 1}º nome: {nome[i]}");
                    Thread.Sleep(2000);
                }
                for (i = 0; i < vtam; i++)
                {

                    ns = gn.Next(0, vtam);

                    WriteLine($"\n\n o nome sorteado foi: {nome[ns]}");
                    Thread.Sleep(2000);
                }
                SetCursorPosition(37, 14);
                Write("Deseja continuar? (s/n)");
                vresp = ReadLine();
            } while (vresp.ToLower() == "s");

        }
        static void duplas()
        {
            string listaNomes;
            Clear();
            WriteLine("Digite os Names: ");
            listaNomes = ReadLine();

            Random gn = new Random();
            int ns, i;
            string[] nome = listaNomes.Split(',');
            int vTam = nome.Length;
            int nd = vTam / 2;
            string[,] par = new string[nd, 2];
            for (i = 0; i < nd; i++)
            {
                for (int c = 0; c <= 1; c++)
                {

                    do
                    {
                        ns = gn.Next(0, vTam);
                    } while (nome[ns] == "*");
                    par[i, c] = nome[ns];
                    nome[ns] = "*";
                }
            }
            // Mostrando os Praes
            WriteLine("\n***Números Pares***");
            for (i = 0; i < nd; i++)
            {
                WriteLine($"{i + 1}º => {par[i, 0]} e {par[i, 1]}");
                Thread.Sleep(1000);

            }
            ReadKey();
        }
        static void conta_letra()
        {
            string vFrase, rFrase = "";
            char[] zenit = { 'z', 'e', 'n', 'i', 't' };
            char[] polar = { 'p', 'o', 'l', 'a', 'r' };
            int i, vTam;

            Clear();

            WriteLine("Digite uma frase para ser coisada: ");
            vFrase = ReadLine();

            vTam = vFrase.Length;

            for (i = 0; i < vTam; i++)
            {
                char vLetra = vFrase[i];
                for (int e = 0; e <= 10; e++)
                {
                    if (vLetra == zenit[i])
                    {
                        rFrase += polar[i];
                    }
                    else if (vLetra == polar[i])
                    {
                        rFrase += polar[i];
                    }
                    else
                    {
                        rFrase += vLetra;
                    }
                }
                Write(rFrase);
                ReadKey();
            }
        }
    }
}