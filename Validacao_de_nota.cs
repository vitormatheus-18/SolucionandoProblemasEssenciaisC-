using System;

class Desafio {
  
    public static void Main() { // Realiza a contagem das notas no semestre.
      
      double somarNotas = 0;
      int contador = 0;
      
      do
      {
        float notaEntrada = float.Parse(Console.ReadLine()); // Recebe os valores informados para notas
        
        if(notaEntrada < 0 || notaEntrada > 10) // Caso as notas estejam fora dessa margem, a nota será inválida.
        {
          Console.WriteLine("nota invalida");
          
        } else {      // Caso sejam valores entre 0 e 10, a nota será registrada para contagem.
          contador++;
          somarNotas += notaEntrada; 
        }
        
      } while (contador < 2); // Recebe as notas válidas e retorna a média.
      
      Console.WriteLine("media = " + (somarNotas / 2).ToString("N2"));
    }
}