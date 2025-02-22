using System;
using static System.Console; //deixa na memoria sempre o console, ai vc n precisa ficar escrevendo console
namespace Projeto_Console_Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            string vresp;
            int opc = 0;
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Gray;
            do 
            {
                Clear();
                SetCursorPosition(0, 0); Write(new string('*', 120));
                SetCursorPosition(50, 1); WriteLine("*** Menu principal ***");
                SetCursorPosition(0, 2);Write(new string('*', 120)); //vai criar * 80 vezes
                SetCursorPosition(25, 3);WriteLine("[1] Ímpar Par");
                SetCursorPosition(25, 4);WriteLine("[2] Cálculo Específico");
                SetCursorPosition(25, 5);WriteLine("[3] Tabuada");
                SetCursorPosition(25, 6);WriteLine("[4] Fim");
                SetCursorPosition(0, 7);Write(new string('*', 120));
                SetCursorPosition(25, 8);Write("Digite sua opção: ");
                SetCursorPosition(42, 8);opc = int.Parse(ReadLine());
                SetCursorPosition(0, 10); Write(new string('*', 120));
                switch (opc)
                {
                    case 1:
                        Impar_Par();
                        break;
                    case 2:
                        Calculo_e();
                        break;
                    case 3:
                        Tabuada();
                        break;
                    default:
                        break;
                    
                }
            } while(opc != 4);
        }
        static void Impar_Par()
        {
            string vresp;
            int n;
            Clear();
            SetCursorPosition(25, 3);
            do
            {
                Clear();
                SetCursorPosition(23, 3); Write("Digite um número: ");
                n = int.Parse(ReadLine());
                SetCursorPosition(25, 4);
                if (n % 2 == 0)
                {
                    SetCursorPosition(23, 4); Write($" {n} é um número par"); //o $ é pra quando colocar a variavel com {} nao entender como texto
                }
                else
                {
                    SetCursorPosition(23, 4); Write($" {n} é um número impar");
                }
                SetCursorPosition(23, 6);
                Write("Deseja continuar? (s/n)");
                vresp = ReadLine();
            } while (vresp.ToLower() == "s");
        }
        static void Calculo_e()
        {
            string vresp = "", calculo;
            int n1, n2;

            do
            {
                Clear();
                SetCursorPosition(23, 12); Write("Digite um número: ");
                n1 = int.Parse(ReadLine());
                SetCursorPosition(23, 13); Write("Digite um outro: ");
                n2 = int.Parse(ReadLine());
                SetCursorPosition(25, 13);
                SetCursorPosition(23, 14); Write("Qual operação você deseja fazer(digite +, -, *, / ou ^): ");
                calculo = ReadLine();

                if (calculo.ToLower() == "+")
                {
                    SetCursorPosition(23, 15); Write($"{n1} + {n2} = {n1 + n2}");
                }
                else if (calculo == "-")
                {
                    SetCursorPosition(23, 15); Write($"{n1} - {n2} = {n1 - n2}");
                }
                else if (calculo == "*")
                {
                    SetCursorPosition(23, 15); Write($"{n1} x {n2} = {n1 * n2}");
                }
                else if (calculo == "/")
                {
                    SetCursorPosition(23, 15); Write($"{n1} / {n2} = {n1 / n2}");
                }
                else if (calculo == "^")
                {
                    int i;
                    double res = Math.Pow(n1, n2);
                    SetCursorPosition(23, 15); Write($"{n1} ^ {n2} = {res}");
                }
                    SetCursorPosition(25, 17);
                    Write("Deseja continuar? (s/n)");
                    vresp = ReadLine();
                } while (vresp.ToLower() == "s") ;
            }
        static void Tabuada()
        {
            string vresp = "";
            int n1, n2;

            do
            {
                Clear();
                SetCursorPosition(23, 12);
                Write("Digite um número: ");
                n1 = int.Parse(ReadLine());

                SetCursorPosition(23, 13);
                Write("Digite até que tabuada você deseja calcular: ");
                n2 = int.Parse(ReadLine());

                SetCursorPosition(23, 15);

                for (int i = 1; i <= n2; i++)
                {
                    Write($"{n1} x {i} = {n1 * i}"); 
                    SetCursorPosition(23, 15 + i); // Posiciona o cursor na linha correta para a próxima iteração
                    if (i == n2)
                    {
                        SetCursorPosition(55, 14 + i);
                    }
                }

                
                Write("Deseja continuar? (s/n) ");
                vresp = ReadLine();

            } while (vresp.ToLower() == "s");
        }

    }
}