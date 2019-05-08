using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaList
{
  class Program
  {
    static void Main(string[] args)
    {
      Elemento uno = new Elemento(4, "hola");
      Elemento dos = new Elemento(6, "nuevo");
      Elemento tres = new Elemento(4, "hola");
      Elemento cinco = new Elemento(6, "nuevo");
      Elemento cuatro = uno;
      List<Elemento> lista = new List<Elemento>();
      lista.Add(uno);
      lista.Add(dos);
      lista.Add(tres);
      Console.WriteLine("Elemntos en lista");
      foreach(Elemento elemento in lista)
      {
        Console.WriteLine(elemento.ToString());
      }
      Console.WriteLine("---------------------\nLista contiene cuatro : {0}", lista.Contains(cuatro));
      Console.WriteLine("Lista contiene cinco : {0}", lista.Contains(cinco));
      Console.WriteLine("Indice de cinco: {0}", lista.FindIndex());
      lista.Remove(uno);
      Console.WriteLine("Saco el uno:");
      foreach (Elemento elemento in lista)
      {
        Console.WriteLine(elemento.ToString());
      }
      Console.ReadKey();
    }
  }
}
