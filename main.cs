using System;
class Calculadora {
  static void Main() {
    int operação, finalizar;
    string nome, tipo;

    finalizar = 1;

    Console.Write("Digite o seu nome de usuário: ");
    nome = Console.ReadLine();
    
    Console.WriteLine("Bem vindo a calculadora, {0}", nome);


    while (finalizar == 1) {
      Console.Write("Digite o tipo da operação que deseja realizar: ");
      tipo = Console.ReadLine();

      if (tipo != "Soma" & tipo != "Multiplicação" & tipo != "Divisão" & tipo != "Subtração") {
      Console.WriteLine("Tipo de operação invalida");
      } else {
        int v1, v2;

        Console.Write("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        if (tipo == "Soma") {
          operação = v1 + v2;

          Console.WriteLine("O resultado é igual a: {0}", operação);
        }

        if (tipo == "Multiplicação") {
          operação = v1 * v2;

          Console.WriteLine("O resultado é igual a: {0}", operação);
        }

        if (tipo == "Divisão") {
          operação = v1 / v2;

          Console.WriteLine("O resultado é igual a: {0}", operação);
        }

        if (tipo == "Subtração") {
          operação = v1 - v2;

          Console.WriteLine("O resultado é igual a: {0}", operação);
        }
        
        Console.Write("DIGITE 0 SE DESEJA ENCERRAR E 1 SE DESEJA CONTINUAR: ");
        finalizar = Convert.ToInt32(Console.ReadLine());
      }
    }
  }
}