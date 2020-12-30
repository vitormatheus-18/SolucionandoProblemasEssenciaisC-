using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  
  static void Main(string[] args) { // Recebe os valores para joia e executa a lista 
    
    string joia = "";
    List<string> joias = new List<string>();
    
    do
    {
      joia = Console.ReadLine(); // Caso os valores sejam inválidos, pare.
      if (string.IsNullOrWhiteSpace(joia))
      {
        break;
        
      } else { // Caso os valores sejam válidos, adcione as joias na lista.
        joias.Add(joia);
      }
      
    } while (true); // Mostra a quantidade de joias as distinguindo, se necessário.
    
    IEnumerable<string> distinctJoias = joias.Distinct();
    
    Console.WriteLine(distinctJoias.Count());
  }

}