using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
  class VariaveisEConstantes {
    public static void Executar() {
      // area da circunferencia
      double raio = 4.5;  // variavel
      const double PI = 3.14;   // constante

      raio = 5.5;
      // PI = 3.1415;: nao pode alterar o valor de uma constante

      double area = PI * raio * raio; // area = pi * raio^2
      Console.WriteLine(area);
      Console.WriteLine("Área é " + area);

      // Tipos internos
      bool estaChovendo = true;
      Console.WriteLine("Está chovendo " + estaChovendo);

      // tipos numericos inteiros
      byte idade = 45;
      Console.WriteLine("Idade " + idade);

      // menor valor possivel
      sbyte saldoDeGols = sbyte.MinValue;
      Console.WriteLine("Saldo de Gols " + saldoDeGols);

      // largest value possible
      short salario = short.MaxValue;
      Console.WriteLine("Salário " + salario);

      int menorValorInt = int.MinValue; // most used integer!
      Console.WriteLine("Menor int " + menorValorInt);

      // integer without signal only positive
      uint populacaoBrasileira = 207_600_000;
      Console.WriteLine("População Brasileira " + populacaoBrasileira);

      long menorValorLong = long.MinValue;
      Console.WriteLine("Menor long " + menorValorLong);

      ulong populacaoMundial = 7_600_000_000;
      Console.WriteLine("População Mundial " + populacaoMundial);

      // tipos numericos reais
      float precoComputador = 1299.99f;
      Console.WriteLine("Preço Computador " + precoComputador);

      double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado dos reais!
      Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);
    }
  }

}
