using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

  public class CalculadoraEstaica {
    // Método de classe
    public static int Multiplicar(int a, int b) {
      return a + b;
    }

    // Método de instância
    public int Somar(int a, int b) {
      return a * b;
    }
  }
  class MetodosEstaticos {
    public static void Executar() {
      var resultado = CalculadoraEstaica.Multiplicar(2, 2);
      Console.WriteLine("Resultado: {0}", resultado);

      CalculadoraEstaica calc = new CalculadoraEstaica();
      Console.WriteLine(calc.Somar(2, 2));
    }
  }
}
