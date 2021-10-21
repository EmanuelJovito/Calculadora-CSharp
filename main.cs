using System;
class Calculadora {
  static void Main() {
    int finalizar;
    string nome, tipo;

    finalizar = 1;

    Console.Write("Digite o seu nome de usuário: ");
    nome = Console.ReadLine();
    
    Console.WriteLine("Bem vindo a calculadora, {0}", nome);


    do {
      Console.Write("Digite o tipo da operação que deseja realizar: ");
      tipo = Console.ReadLine();
      tipo = tipo.ToLower();

      if (tipo != "soma" & tipo != "multiplicação" & tipo != "divisão" & tipo != "subtração") {
      Console.WriteLine("Tipo de operação invalida");
      } else {
        int v1, v2, res;

        Console.Write("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        switch (tipo) {
          case "soma" :
            res = Soma(v1, v2);

            Console.WriteLine("O resultado é igual a: {0}", res);
            break;

          case "multiplicação" :
            res = Multiplicação(v1, v2);

            Console.WriteLine("O resultado é igual a: {0}", res);
            break;

          case "divisão" :
            res = Divisão(v1, v2);

            Console.WriteLine("O resultado é igual a: {0}", res);
            break;

          case "subtração" :
            res = Subtração(v1, v2);

            Console.WriteLine("O resultado é igual a: {0}", res);
            break;
        }
        
        Console.Write("DIGITE 0 SE DESEJA ENCERRAR E 1 SE DESEJA CONTINUAR: ");
        finalizar = Convert.ToInt32(Console.ReadLine());
      }

      Console.Clear();
    } while(finalizar == 1);
  }

  static int Soma(int v1, int v2) {
    int operação = v1 + v2;

    return operação;
  } 

  static int Multiplicação(int v1, int v2) {
    int operação = v1 * v2;

    return operação;
  } 

  static int Divisão(int v1, int v2) {
    int operação = v1 / v2;

    return operação;
  } 

  static int Subtração(int v1, int v2) {
    int operação = v1 - v2;

    return operação;
  } 
}