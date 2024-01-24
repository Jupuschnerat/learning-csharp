using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
  class OperadoresLogicos {
    public static void Executar() {
      var executouTrabalho1 = false;
      var executouTrabalho2 = false;

      // e
      var comprouTv50 = executouTrabalho1 && executouTrabalho2;
      Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

      // ou
      var comprouSorvete = executouTrabalho1 || executouTrabalho2;
      Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

      // ou exclusivo
      var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
      Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

      // negacao logica
      Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
    }

  }
}
