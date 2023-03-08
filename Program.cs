using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
        static void Main(string[] args)
        {
            string nome, dis;
            double[,] nota = new double[3, 3];
            double[] md = new double[3];
            double mf;
            int x;
            Console.Write("Total de alunos são..:");
            x = int.Parse(Console.ReadLine());
            for (int cont = 1; cont <= x; cont++)
            {
                Console.WriteLine("");
                Console.Write("Aluno número..:" + cont);
                Console.WriteLine("");

                Console.Write("Digite o nome do aluno..:");
                nome = Console.ReadLine();
                Console.Write("Digite a disciplina..:");
                dis = Console.ReadLine();
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                    DIGITE AS 3 NOTAS DO PRIMEIRO TRIMESTRE                                            |");
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write("Digite a primeira nota..:");

                nota[0, 0] = double.Parse(Console.ReadLine());
                Console.Write("Digite a segunda nota..:");
                nota[0, 1] = double.Parse(Console.ReadLine());
                Console.Write("Digite a terceira nota..:");
                nota[0, 2] = double.Parse(Console.ReadLine());
                md[0] = (nota[0, 0] + nota[0, 1] + nota[0, 2]) / 3;
                Console.WriteLine("A MEDIA DO PRIMEIRO TRIMESTRE É..:" + md[0]);
                Console.WriteLine("___________________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                            APROVEITAMENTO DO PRIMEIRO TRIMESTRE                                                  |");
                Console.WriteLine("|______________________________________________________________________________________________________________________________________|");
                Console.WriteLine("|NOME                     | DISCIPLINA               |   NOTA1               |   NOTA2                |   NOTA3                 | ");
                Console.WriteLine("|" + nome + "   \t            " + dis + "      \t            " + nota[0, 0] + "       \t          " + nota[0, 1] + "                    " + nota[0, 2] + "");
                Console.WriteLine("|_________________________|__________________________|_______________________|________________________|_________________________|____________________________________________________|");
                Console.WriteLine("");

                nome = nome;

                dis = dis;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                       DIGITE AS 3 NOTAS DO SEGUNDO TRIMESTRE                                          |");
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write("Digite a primeira nota..:");
                nota[1, 0] = double.Parse(Console.ReadLine());
                Console.Write("Digite a segunda nota..:");
                nota[1, 1] = double.Parse(Console.ReadLine());
                Console.Write("Digite a terceira nota..:");
                nota[1, 2] = double.Parse(Console.ReadLine());
                md[1] = (nota[1, 0] + nota[1, 1] + nota[1, 2]) / 3;
                md[1] = Math.Round(nota[1, 0] + nota[1, 1] + nota[1, 2]) / 3;
                Console.WriteLine("A MEDIA DO SEGUNDO TRIMESTRE É..:" + md[1]);
                Console.WriteLine("___________________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                            APROVEITAMENTO DO SEGUNDO TRIMESTRE                                                  |");
                Console.WriteLine("|______________________________________________________________________________________________________________________________________|");
                Console.WriteLine("|NOME                     | DISCIPLINA               |   NOTA1               |   NOTA2                |   NOTA3                 | ");
                Console.WriteLine("|" + nome + "   \t        " + dis + "      \t            " + nota[1, 0] + "       \t          " + nota[1, 1] + "                    " + nota[1, 2] + "");
                Console.WriteLine("|_________________________|__________________________|_______________________|________________________|_________________________|____________________________________________________|");
                Console.WriteLine("");
                nome = nome;

                dis = dis;
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                         DIGITE AS 3 NOTAS DO TERCEIRO TRIMESTRE                                       |");
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write("Digite a primeira nota..:");
                nota[2, 0] = double.Parse(Console.ReadLine());
                Console.Write("Digite a segunda nota..:");
                nota[2, 1] = double.Parse(Console.ReadLine());
                Console.Write("Digite a terceira nota..:");
                nota[2, 2] = double.Parse(Console.ReadLine());
                md[2] = (nota[2, 0] + nota[2, 1] + nota[2, 2]) / 3;
                Console.WriteLine("A MEDIA DO SEGUNDO TRIMESTRE É..:" + md[2]);
                Console.WriteLine("___________________________________________________________________________________________________________________________________");
                Console.WriteLine("|                                            APROVEITAMENTO DO TERCEIRO TRIMESTRE                                                  |");
                Console.WriteLine("|______________________________________________________________________________________________________________________________________|");
                Console.WriteLine("|NOME                     | DISCIPLINA               |   NOTA1               |   NOTA2                |   NOTA3                 | ");
                Console.WriteLine("|" + nome + "        \t            " + dis + "      \t            " + nota[2, 0] + "       \t          " + nota[2, 1] + "                    " + nota[2, 2] + "");
                Console.WriteLine("|_________________________|__________________________|_______________________|________________________|_________________________|____________________________________________________|");
                Console.WriteLine("");

                mf = (md[0] + md[1] + md[2]) / 3;
                if (mf < 10)
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("|                                                       PAUTA FINAL                                                         |");
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("|NOME                |   DISCIPLINA        |   Primeiro Timestre     |   SegundoTimestre    |   Terceiro Timestre   | Média Final      | Observação    |");
                    Console.WriteLine("|" + nome + "                 \t         " + dis + "  \t              " + md[0] + "\t       " + md[1] + "\t                 " + md[2] + "    \t      " + mf + "\t              Reprovado");
                    Console.WriteLine("|______________|__________________|_______________________|______________________|_______________________|__________________|_______________|");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("|                                                    PAUTA FINAL                                                           |");
                    Console.WriteLine("___________________________________________________________________________________________________________________________________________");
                    Console.WriteLine("|NOME          |   DISCIPLINA     |   Primeiro Timestre   |   SegundoTimestre    |   Terceiro Timestre   | Média Final      | Observação    |");
                    Console.WriteLine("|" + nome + "            \t     " + dis + " \t             " + md[0] + " \t                 " + md[1] + " \t                 " + md[2] + "    \t         " + mf + "\t          Aprovado");
                    Console.WriteLine("|______________|__________________|_______________________|______________________|_______________________|__________________|_______________|");
                    Console.WriteLine("");
                }


            }


            Console.ReadKey();

        }
    }







