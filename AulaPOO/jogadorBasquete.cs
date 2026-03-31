using System;
using System.Collections.Generic;
using System.Text;

namespace AulaPOO
{
    internal class jogadorBasquete : jogador
    {
        public String nome;
        public int idade;
        public double altura;
        public int doisPontos;
        public int tresPontos;
        public int pontos;

        public int pontosCalculados;

        public void calcularPontos()
        {
            pontosCalculados = (doisPontos * 2) + (tresPontos * 3) + pontos;
            Console.WriteLine(pontosCalculados);
        }
        protected override void cadastrarJogador()
        {
   

            Console.WriteLine("Insira o nome do jogador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a idade do jogador:");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insira a altura do jogador");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos pontos de dois?");
            doisPontos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quantos pontos de tres?");
            tresPontos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Quantos pontos?");
            pontos = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("O jogador"+"" + nome + "" + "Possui" + idade + "anos de idade" +"" + "Tem tantos pontos de dois"+ "" + doisPontos + "" + "Tem pontos de  Tres "+ "" + tresPontos + "" + "Tem tantos pontos unicos"+ "" + altura + "" + "De altura");
            //-----------------------------------------------
            Console.WriteLine("Dados Tecnicos");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade" + idade);
            Console.WriteLine("Altura:" + altura);
            calcularPontos();

        {


        }
        {
           




        };
    }
    }
}
