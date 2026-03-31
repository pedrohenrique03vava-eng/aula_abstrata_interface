using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AulaPOO
{
    internal class jogadorFutsal : jogador
    {
        public String nome;
        public int idade;
        public int gols;
        public double peso;
        public double altura;
        public String time;
        public String posicao;

        protected override void cadastrarJogador()
        {
            Console.WriteLine("Insira o nome do jogador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a idade do jogador:");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de gols do jogador:");
            gols = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Insira o peso do jogador:");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a altura do jogador");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o time do jogador");
            time = Console.ReadLine();
            Console.WriteLine("Digite a posição do jogador");
            posicao = Console.ReadLine();


            Console.WriteLine("O jogador" + nome + "Possui" + idade + "anos de idade" + "tem" + gols + "gols" + "Pesa" + peso + "Kg" + "Tem" + altura + "De altura" + "Atua pelo" + time + "FC" + "Joga na posição de" + posicao);
            //-----------------------------------------------
            Console.WriteLine("Dados Tecnicos");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade" + idade);
            Console.WriteLine("Gols:" + gols);
            Console.WriteLine("Peso:"+ peso);
            Console.WriteLine("Altura:"+ altura);
            Console.WriteLine("Time:" + time);
            Console.WriteLine("Posição"+ posicao);


            
        }
        public void chamarCadastro()
        {
            cadastrarJogador();
        }
    }
}
