using System;

class Desafio {
   public static void Main() {
        var numero = Int32.Parse(Console.ReadLine()); // Recebe um valor inteiro entre 1 e 1000, este delimitará a quantidade de linhas de saída.
        
        if(numero != null) //Se o número digitado for diferente de nulo
        {
          for(int i = 1; i <= numero; i++) // Começará uma contagem do número 1 até o valor informado anteriormente "numero", distribuidos em linhas.
          {
           var numeros = $"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}"; // Para cada linha será calculado o quadrado o cubo do valor. Ex: 2^2 = 4, 2^3 = 8.
            Console.WriteLine(numeros);
          }
        } else {
          Console.WriteLine("Insira um novo número entre 1 e 1000:"); // Caso o valor "numero" esteja fora da regra, será pedida a inserção de um novo valor para "numero".
        }
    }
}