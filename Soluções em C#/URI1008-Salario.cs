/*
URI Online Judge | 1008 | Salário

Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe 
por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com 
duas casas decimais.

Entrada: O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o 
número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída: Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes 
e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.

-----------------------------------------------
Exemplos de Entrada |   Exemplos de Saída
-----------------------------------------------
25                  |
100                 |    NUMBER = 25
5.50                |    SALARY = U$ 550.00
-----------------------------------------------
1                   |
200                 |    NUMBER = 1
20.50               |    SALARY = U$ 4100.00
-----------------------------------------------
6                  |
145                |     NUMBER = 6
15.55              |     SALARY = U$ 2254.75  
-----------------------------------------------
*/

using System; 
 
class URI {
 
    static void Main(string[] args) { 
      int funcionario, horasTrabalhadas;
      double valorHora, salario; 

      funcionario = int.Parse(Console.ReadLine());
      horasTrabalhadas = int.Parse(Console.ReadLine());
      valorHora = double.Parse(Console.ReadLine());

      salario = horasTrabalhadas * valorHora;

      Console.WriteLine("NUMBER = {0}", funcionario);
      Console.WriteLine("SALARY = U$ {0:F2}", salario);
    }
    
}
