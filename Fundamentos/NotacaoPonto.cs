using System;
using System.Text;
using System.Collections.Generic;

namespace CursoCSharp.Fundamentos {
  class NotacaoPonto {
    public static void Executar() {
      var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
      Console.WriteLine(saudacao);

      Console.WriteLine("Teste".Length);

      string valorImportante = null;
      Console.WriteLine(valorImportante?.Length); // null propagation

    }
  }

}
