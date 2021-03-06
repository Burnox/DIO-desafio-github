using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
  // Exemplo de polimorfismo tempo de compilação
  public class calculadora : ICalculadora
  {
    public int Dividir(int num1, int num2)
    {
      return num1 / num2;
    }

    public int Multiplicar(int num1, int num2)
    {
      return num1 * num2;
    }

    public int Somar(int num1, int num2)
    {
      return num1 + num2;
    }
    public int Somar(int num1, int num2, int num3)
    {
      return num1 + num2 + num3;
    }

    public int Subtrair(int num1, int num2)
    {
      return num1 - num2;
    }
  }
}