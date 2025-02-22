using System;
using static System.Console;

namespace Projeto_Console_Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.Gray;

            do
            {
                Clear();
                SetCursorPosition(0, 0);
                Write(new string('*', 120));

                SetCursorPosition(50, 1);
                WriteLine("*** Menu principal ***");

                SetCursorPosition(0, 2);
                Write(new string('*', 120));

                SetCursorPosition(25, 3); WriteLine("[1] Cálculo Específico");
                SetCursorPosition(25, 4); WriteLine("[2] Contagem");
                SetCursorPosition(25, 5); WriteLine("[3] Número por Extenso");
                SetCursorPosition(25, 6); WriteLine("[4] Jogo Advinha Número");
                SetCursorPosition(25, 7); WriteLine("[5] Sorteia Nomes");
                SetCursorPosition(25, 8); WriteLine("[6] Sorteia Duplas");
                SetCursorPosition(25, 9); WriteLine("[7] Fim");

                SetCursorPosition(0, 10); Write(new string('*', 120));

                SetCursorPosition(25, 11);
                Write("Digite sua opção: ");
                SetCursorPosition(42, 11);
                opc = int.Parse(ReadLine());
                SetCursorPosition(0, 13);

                switch (opc)
                {
                    case 1:
                        CalculoEspecifico();
                        break;
                    case 2:
                        contagem();
                        break;
                    case 3:
                        extenso();
                        break;
                    case 4:
                        adivinhar();
                        break;
                    default:
                        break;
                }
            } while (opc != 5);
        }

        static void CalculoEspecifico()
        {
            string vresp = "", calculo;
            int n1, n2;

            do
            {
                Clear();
                WriteLine("Digite um número: ");
                n1 = int.Parse(ReadLine());
                WriteLine("Digite um outro: ");
                n2 = int.Parse(ReadLine());
                WriteLine("Qual operação você deseja fazer (digite +, -, *, / ou ^): ");
                calculo = ReadLine();

                if (calculo == "+")
                {
                    WriteLine($"{n1} + {n2} = {n1 + n2}");
                }
                else if (calculo == "-")
                {
                    WriteLine($"{n1} - {n2} = {n1 - n2}");
                }
                else if (calculo == "*")
                {
                    WriteLine($"{n1} x {n2} = {n1 * n2}");
                }
                else if (calculo == "/")
                {
                    if (n2 != 0)
                    {
                        WriteLine($"{n1} / {n2} = {(double)n1 / n2}");
                    }
                    else
                    {
                        WriteLine("Erro tente novamente!");
                    }
                }
                else if (calculo == "^")
                {
                    double res = Math.Pow(n1, n2);
                    WriteLine($"{n1} ^ {n2} = {res}");
                }
                else
                {
                    WriteLine("Operação inválida!");
                }

                WriteLine("Deseja continuar? (s/n): ");
                vresp = ReadLine();
            } while (vresp.ToLower() == "s");

            WriteLine("Voltando ao menu...\n");
            Thread.Sleep(2000);
        }

        static void contagem()
        {
            int inicio, fim, passo;
            string opcao;

            do
            {
                Clear();

                Write("Digite de onde você deseja iniciar a contagem: ");
                inicio = int.Parse(ReadLine());

                Write("Digite o passo da contagem: ");
                passo = int.Parse(ReadLine());

                Write("Digite o final da sua contagem: ");
                fim = int.Parse(ReadLine());

                do
                {
                    Write(inicio);

                    if (inicio + passo > fim)
                    {
                        Write(".");
                    }
                    else
                    {
                        Write(", ");
                    }

                    Thread.Sleep(1000);

                    inicio += passo;
                } while (inicio <= fim);

                Thread.Sleep(3000);

                Write("\nDeseja continuar contando? (S/N): ");
                opcao = ReadLine().ToUpper();
            } while (opcao == "S");

            WriteLine("Voltando ao menu...\n");
            Thread.Sleep(2000);
        }

        static void extenso()
        {
            int n, nd, ne, resto, centena;
            string[] unidades = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            string opcao;

            do
            {
                Clear();
                WriteLine("Digite um número entre 0 e 1000 válido:");
                n = int.Parse(ReadLine());

                if (n < 0 || n > 1000)
                {
                    WriteLine("ERRO!! Digite um número válido");
                    Thread.Sleep(3000);
                }
                else
                {
                    if (n == 100)
                    {
                        WriteLine("cem");
                    }
                    else if (n == 1000)
                    {
                        WriteLine("mil");
                    }
                    else if (n >= 0 && n <= 19)
                    {
                        WriteLine(unidades[n]);
                    }
                    else if (n >= 20 && n <= 99)
                    {
                        ne = n / 10;
                        nd = n % 10;

                        Write(dezenas[ne]);
                        if (nd > 0)
                        {
                            Write(" e " + unidades[nd]);
                        }
                        WriteLine();
                    }
                    else if (n >= 100 && n <= 999)
                    {
                        centena = n / 100;
                        resto = n % 100;

                        Write(centenas[centena]);

                        if (resto > 0)
                        {
                            Write(" e ");
                            if (resto >= 0 && resto <= 19)
                            {
                                Write(unidades[resto]);
                            }
                            else
                            {
                                ne = resto / 10;
                                nd = resto % 10;

                                Write(dezenas[ne]);
                                if (nd > 0)
                                {
                                    Write(" e " + unidades[nd]);
                                }
                            }
                        }
                        WriteLine();
                    }
                }

                Write("\nDeseja continuar verificando os números? (S/N): ");
                opcao = ReadLine().ToUpper();
            } while (opcao == "S");

            WriteLine("Voltando ao menu...\n");
            Thread.Sleep(2000);
        }

        static void adivinhar()
        {
            Random gerarnum = new Random();
            int NS, n, tentativas;
            string opcao;

            do
            {
                Clear();
                NS = gerarnum.Next(1, 11); // Gera um número entre 1 e 10
                tentativas = 0;

                WriteLine("Um número foi sorteado entre 1 e 10. Tente adivinhar!");

                while (tentativas < 5)
                {
                    tentativas++;
                    Write($"Tentativa nº {tentativas}: Digite seu palpite: ");
                    n = int.Parse(ReadLine());

                    if (n > NS)
                    {
                        WriteLine("Palpite errado! O número sorteado é menor.");
                    }
                    else if (n < NS)
                    {
                        WriteLine("Palpite errado! O número sorteado é maior.");
                    }
                    else
                    {
                        WriteLine("Parabéns, você acertou o número!");
                        break; // Interrompe o loop ao acertar
                    }

                    WriteLine($"Tentativas restantes: {5 - tentativas}");
                }

                if (tentativas == 5 && n != NS)
                {
                    WriteLine($"Você perdeu! O número sorteado era {NS}.");
                }

                Write("\nDeseja continuar jogando? (S/N): ");
                opcao = ReadLine().ToUpper();

            } while (opcao == "S");

            WriteLine("Voltando ao menu...\n");
            Thread.Sleep(2000);
        }

    }
}