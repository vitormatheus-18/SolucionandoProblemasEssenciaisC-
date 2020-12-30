using System;

class Desafio {
  
      public static void Main() {
        
      int quantidadeEntradas = 3;
      while(quantidadeEntradas > 0)
      {
        var numeroQuantidade = Int32.Parse(Console.ReadLine()); // Recebe o valor de tartarugas
        
        if(numeroQuantidade >= 1 && numeroQuantidade <= 500) // Delimita o valor para a quantidade de tartarugas.
        {
          
          string[] tartarugas = Console.ReadLine().Split(" "); // Seleciona a tartaruga de maior velocidade no grupo.
          
          var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
          for(int i = 1; i < numeroQuantidade; i++)
          {
            var tartaruga = Int32.Parse(tartarugas[i]);
            
            if( tartaruga > maiorVelocidade)
            {
              maiorVelocidade = tartaruga;
            }
          }
          
          // Classifica as tartarugas de acordo com a velocidade.
          
          if(maiorVelocidade < 10)
          {
            Console.WriteLine(1);
          }
          else if(maiorVelocidade >= 10 && maiorVelocidade < 20)
          {
            Console.WriteLine(2);
          }
          else if(maiorVelocidade >= 20)
          {
            Console.WriteLine(3);
          }
          
          quantidadeEntradas--;
          
        } else {
          Console.WriteLine("Insira um número entre 1 e 500"); //Caso o valor esteja fora dessa pré-definição, será soliciticado um novo valor para a quantidade de tartarugas.
        }
      }
    }
}