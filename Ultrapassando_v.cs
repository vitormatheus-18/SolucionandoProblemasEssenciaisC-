using System;

class Desafio {
    static void Main() {
      
      var R = Int32.Parse(Console.ReadLine()); // Recebe o valor para R e V, sendo que V só será aceito quando V > R.
      var V = 0;
      var contador = 1;
        
      do                                      //  Realiza a contagem dos valores válidos de R e V
      {
        V = Int32.Parse(Console.ReadLine());
      } while (V <= R);
      
      int i = R;
      
      while (i <= V)
      {
        contador++;
        R += 1;
        i += R;
      }
      
      Console.WriteLine(contador);
      
    }
}