/*
URI Online Judge | 1007 | Diferença

Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo 
produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

Entrada: O arquivo de entrada contém 4 valores inteiros.

Saída: Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

----------------------------------------------
Exemplos de Entrada |  Exemplos de Saída
----------------------------------------------
5                   |
6                   |
7                   |
8                   |    DIFERENCA = -26
---------------------------------------------   
0                   |
0                   |
7                   |
8                   |    DIFERENCA = -56
--------------------------------------------    
5                   |
6                   |
-7                  |
8                   |    DIFERENCA = 86
--------------------------------------------
*/

using System; 
 
class URI {
 
    static void Main(string[] args) { 
      double a,b,c,d, DIFERENCA ; 

      a = double.Parse(Console.ReadLine());
      b = double.Parse(Console.ReadLine());
      c = double.Parse(Console.ReadLine());
      d = double.Parse(Console.ReadLine());

      DIFERENCA = (a * b - c * d);

      Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
    }
    
}