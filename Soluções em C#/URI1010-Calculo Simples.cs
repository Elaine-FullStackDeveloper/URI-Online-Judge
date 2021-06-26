/*
URI Online Judge | 1010 | Cálculo Simples

Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a 
ser pago.

Entrada: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente 
dois inteiros e um valor com 2 casas decimais.

Saída: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço 
após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.

-----------------------------------------------
Exemplos de Entrada  |	Exemplos de Saída
-----------------------------------------------
12 1 5.30            |
16 2 5.10            | VALOR A PAGAR: R$ 15.50
-----------------------------------------------
13 2 15.30           |
161 4 5.20           | VALOR A PAGAR: R$ 51.40
-----------------------------------------------
1 1 15.10            |
2 1 15.10            | VALOR A PAGAR: R$ 30.20
-----------------------------------------------
*/

using System; 
 
class URI {
 
    static void Main(string[] args) { 
      int cod1, num1, cod2, num2;
      double valor1, valor2, valorFinal;

      string[] linha1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(linha1[0]);
            num1 = int.Parse(linha1[1]);
            valor1 = double.Parse(linha1[2]);

      string[] linha2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(linha2[0]);
            num2 = int.Parse(linha2[1]);
            valor2 = double.Parse(linha2[2]);

      valorFinal = (num1*valor1)+(num2*valor2);

      Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", valorFinal);
    }
    
}
