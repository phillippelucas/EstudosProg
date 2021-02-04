using System;

namespace Estudos1
{
    class Program
    {
   

        static void Main(string[] args)
        {

        }
        public class Elevador
        {
            private int AndarAtual;
            private int Andares;
            private byte NumeroPessoas;
            private int CapacidadeTotal;
            public Elevador(int andarAtual, int andares, byte pessoas, int capacidade)
            {
                AndarAtual = andarAtual;
                Andares = andares;
                NumeroPessoas = pessoas;
                CapacidadeTotal = capacidade;
            }

            public void Subir()
            {
                if (AndarAtual == Andares)
                {
                    Console.WriteLine("Este é o ultimo andar!!!");
                }
                else
                {
                    AndarAtual++;
                }
            }

            public void Descer()
            {
                if (AndarAtual != 0)
                {
                    AndarAtual--;
                }
                else
                {
                    Console.WriteLine("Este é o Terreo!!!");
                }
            }
            public void EntrarPessoas(byte quantidadePessoas)
            {
                if (NumeroPessoas == CapacidadeTotal)
                {
                    Console.WriteLine("ta cheio!!!");
                }
                else
                {
                    NumeroPessoas++;

                }

            }
            public void SairPessoas(byte quantidadePessoas)
            {
                if (NumeroPessoas == 0)
                {
                    Console.WriteLine("Hein???");
                }
                else
                {
                    NumeroPessoas--;
                }
            }
            public int ConsultarAndarAtual()
            {
                return AndarAtual;
            }
            public byte ConsutalQuantidadePessoas()
            {
                return NumeroPessoas;
            }
        }
        //exercicio 2
        public class console
        {
            private string NomeConsole;
            private string TelaAtual;
            private string NomeJogo;
            private bool JogoRodando;
            private bool EstaLigado;
            
            public console(string nome)
            {
                NomeConsole = nome;
                

            }
            public void LigarOuDesligar()
            {
                if (EstaLigado == true)
                {
                    EstaLigado = false;
                }
                else
                {
                    EstaLigado = true;
                    TelaAtual = "Menu";
                    NomeJogo = " ";
                    JogoRodando = false;     
                }
            }
            public string ConsultarJogoAtual()
            {
                return NomeJogo;

            }
            public bool EstaRodandoJogo()
            {
                if (JogoRodando == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            public void RodarJogo(string nomeJogo)
            {
                NomeJogo = nomeJogo;
                TelaAtual = "rodando jogo...";
            }

            public void VoltarMenu()
            {
                TelaAtual = "Menu";
            }


        }
        //Exercicio 3
        public class EstoqueProduto
        {
            private string NomeProduto;
            private int QuantAtual;
            private int QuantMaxima;
            private decimal Preco;

            public EstoqueProduto(string nome, int quantAtual, int quantmaxima, int preco)
            {
                NomeProduto = nome;
                QuantAtual = quantAtual;
                QuantMaxima = quantmaxima;
                Preco = preco;
            }
            public int ConsultarQuantidadeAtual()
            {
                return QuantAtual;
            }
            public decimal ConsultarValorTotal()
            {
                return QuantAtual * Preco;
            }
            public void BaixarProduto(int quantidade)
            {
                if (quantidade == 0)
                    return;

                if (quantidade > 0)
                {
                    if (QuantAtual + quantidade > QuantMaxima)
                    {
                        Console.WriteLine("Estoque lotado");
                    }
                    else
                    {
                        QuantAtual = QuantAtual + quantidade;
                    }

                }
                else if (quantidade < 0)
                {
                    if (QuantAtual - quantidade < 0)
                    {
                        Console.WriteLine("não tem isso tudo");
                    }
                    else
                    {
                        QuantAtual = QuantAtual - quantidade;
                    }
                    
                }
            }
        }

     
    }
 }
