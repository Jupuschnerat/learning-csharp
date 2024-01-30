using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notacao Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero  - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes  - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos  - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais  - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos  - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuicao  - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios  - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario  - Fundamentos", OperadoresTernario.Executar},

                //estruturas de controle
                {"Estrutura If  - Estruturas De Controle", EstruturaIf.Executar},
                {"Estrutura If Else - Estruturas De Controle", EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estruturas De Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas De Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas De Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas De Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas De Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas De Controle", UsandoContinue.Executar},

                // Classes e metodos
                {"Membros - Estruturas De Controle", Membros.Executar},
                {"Construtores - Estruturas De Controle", Construtores.Executar},
                {"Metodos Com Retorno - Estruturas De Controle", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Estruturas De Controle", MetodosEstaticos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}
