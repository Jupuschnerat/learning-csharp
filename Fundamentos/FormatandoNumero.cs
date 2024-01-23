using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
  class FormatandoNumero {
    public static void Executar() {
      double valor = 15.175;
      Console.WriteLine(valor.ToString("F1")); // 15.2
      Console.WriteLine(valor.ToString("C")); // R$ 15,18
      Console.WriteLine(valor.ToString("P")); // 1.518%
      Console.WriteLine(valor.ToString("#.##")); // 15,18
      Console.WriteLine(valor.ToString("F3")); // 15,175
      Console.WriteLine(valor.ToString("0.##")); // 15,18

      CultureInfo cultura = new CultureInfo("pt-BR");
      Console.WriteLine(valor.ToString("C0", cultura)); // R$ 15
      Console.WriteLine(valor.ToString("C3", cultura)); // R$ 15,175

      int inteiro = 256;
      Console.WriteLine(inteiro.ToString("D10")); // 0000000256
    }
  }
}
