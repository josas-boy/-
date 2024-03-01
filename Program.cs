using System;

namespace xadrez
{
    class Xadrez()
    {
        public int hi;
        public int hf;
        public bool limite;
        public int tempo;
        public string borda = "\n------------------------";

        public void tempo_do_jogo()
        {
            try
            {
                Console.Write("Insira a hora inicial do jogo: ");
                hi = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Incorrecto. Apenas é permitido inserir números inteiros");
                Console.Write("Insira a hora inicial do jogo: ");
                hi = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("Insira a hora final do jogo: ");
                hf = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Incorrecto. Apenas é permitido inserir números inteiros");
                Console.Write("Insira a hora final do jogo: ");
                hf = Convert.ToInt32(Console.ReadLine());
            }

            limite = hi >= 0 && hi <= 24 && hf >= 0 && hf <= 24;

            Console.WriteLine(borda);
            if (limite == true)
            {
                if (hi > hf)
                {
                    hf = hf + 24;
                    int tempo = hf - hi;
                    Console.WriteLine("O jogo de xadrêz levou " + tempo + " horas para terminar.");
                }
                else
                {
                    if (hf > hi)
                    {
                        int tempo = hf - hi;
                        Console.WriteLine("O jogo de xadrêz levou " + tempo + " horas para terminar.");
                    }
                    else
                    {
                        Console.WriteLine("As horas são idênticas. Selecione uma das opções");
                        Console.WriteLine("a) Mesmo dia");
                        Console.WriteLine("b) Dia seguinte");
                        char escolha;
                        try
                        {
                            escolha = Convert.ToChar(Console.ReadLine());
                            if (escolha == 'a')
                            {
                                Console.WriteLine(borda);
                                Console.WriteLine("O jogo de xadrêz terminou na mesma hora\n(teve duração abaixo de 1 hora)");
                            }
                            else
                            {
                                Console.WriteLine(borda);
                                Console.WriteLine("O jogo de xadrêz levou 24 horas para terminar.");
                            }


                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Incorreto. Insira apenas a letra (a) ou (b)");
                            escolha = Convert.ToChar(Console.ReadLine());
                            if (escolha == 'a')
                            {
                                Console.WriteLine(borda);
                                Console.WriteLine("O jogo de xadrêz terminou na mesma hora\n(teve duração abaixo de 1 hora)");
                            }
                            else
                            {
                                Console.WriteLine(borda);
                                Console.WriteLine("O jogo de xadrêz levou 24 horas para terminar.");
                            }
                        }
                        
                    }


                }


            }
            

            else
            {
                Console.WriteLine("As horas são inválidas.\nRegra: As horas só podem ser de 0 a 24 horas");
            }
        }
    }
    class Program
    {
        static void Main()
        {

            Borda Estilo = new Borda();
            Xadrez xadrez = new Xadrez();
            string borda = "\n------------------------";
            Estilo.show();
            xadrez.tempo_do_jogo();
            Console.WriteLine(borda);
            Console.WriteLine("Vamos analizar um novo jogo?");
            string repetir = Console.ReadLine();
            bool repeticao = repetir == "sim" || repetir == "Sim" || repetir == "s" || repetir == "SIM" || repetir == "S";

            if (repeticao == true)
            {
                do
                {
                    Console.WriteLine(borda);
                    xadrez.tempo_do_jogo();
                    Console.WriteLine(borda);
                    Console.WriteLine("Vamos analizar um novo jogo?");
                    repetir = Console.ReadLine();
                    repeticao = repetir == "sim" || repetir == "Sim" || repetir == "s" || repetir == "SIM" || repetir == "S";
                } while (repeticao == true);
            }  
            else
            {
                Console.WriteLine(borda);
                Console.WriteLine("Terminamos por aqui.");
            }
            

            Console.ReadKey();
        }
    }
    public class Borda
    {

        public void show()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|  Horas do jogo de Xadrêz  |");
            Console.WriteLine("-----------------------------\n");
        }
    }
}