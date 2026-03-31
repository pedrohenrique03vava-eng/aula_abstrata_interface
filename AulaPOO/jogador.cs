using System;
using System.Collections.Generic;
using System.Text;

namespace AulaPOO
{
    internal abstract class jogador
    {
        public String nomeJogador;
        public int idade;
        public double altura;
        public double peso;
      protected abstract void cadastrarJogador();
    }
}
