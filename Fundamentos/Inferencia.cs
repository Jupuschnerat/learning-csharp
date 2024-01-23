using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.Fundamentos {
  class Inferencia {
    public static void Executar() {
      var nome = "Leonardo";
      // nome = 123; // nao pode mudar o tipo da variavel
      Console.WriteLine(nome);

      // int idade;
      var idade = 32;
      Console.WriteLine(idade);

      int a;
      a = 3;

      int b = 2;

      Console.WriteLine(a + b);
    }

  }

}
