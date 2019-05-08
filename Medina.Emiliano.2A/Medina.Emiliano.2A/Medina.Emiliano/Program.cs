using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medina.Emiliano
{
  class Program
  {
    static void Main(string[] args)
    {
      Perro perroUno = null;
      Perro perroCuatro = null;
      Perro perroDos = new Perro("Julio", "Cruza", 13, false);
      Perro perroTres = new Perro("Julio", "Cruza", 13, false);
      Perro perroCinco = new Perro("julio", "Cruza", 13, false);
      Perro perroSeis = new Perro(null, null, 15, false);
      Console.WriteLine("Perro DOS - Perro tres : {0}", perroDos.Equals(perroTres));
      Console.WriteLine("Perro uno - Perro dos : {0}", perroDos.Equals(perroUno));
      //Console.WriteLine("Perro uno - Perro cuatro con Equals: {0}", perroUno.Equals(perroCuatro));
      Console.WriteLine("Perro uno - Perro cuatro con Object.Equals: {0}", Object.Equals(perroUno, perroCuatro));
      Console.WriteLine("Perro dos - Perro tres con Object.Equals: {0}", Object.Equals(perroDos, perroTres));
      Console.WriteLine("Perro uno - null con Object.Equals: {0}", Object.Equals(perroUno, null));
      Console.WriteLine("Perro uno - perro cuatro con =: {0}", (perroUno == perroCuatro));
      Console.WriteLine("Perro tres - perro cinco con =: {0}", (perroTres == perroCinco));
      Console.WriteLine("Perro tres - perro seis con =: {0}", (perroTres == perroSeis));

      /*
      Gato gatoUno = new Gato("José", "Angora");
      Gato gatoDos = new Gato("Hernán", "Cruza");
      Gato gatoTres = new Gato("Fer", "Siamés");
      */ 
      Grupo grupoUno = new Grupo("Río", EtipoManada.Mixta);
      grupoUno += perroDos;
      grupoUno += perroTres;
      grupoUno += perroCinco;
      Console.WriteLine(grupoUno);
      Console.WriteLine("--------------------\nLista con remove de perro dos:");
      grupoUno -= perroTres;
      Console.WriteLine(grupoUno);
      /*
      grupoUno += perroTres;
      grupoUno += gatoUno;
      grupoUno += gatoDos;
      grupoUno += gatoTres;
      Console.WriteLine(grupoUno);
      grupoUno -= perroTres;
      grupoUno -= gatoTres;
      grupoUno -= gatoTres;
      Console.WriteLine(grupoUno);
      if (perroUno.Equals("perroUno"))
        Console.WriteLine("Son la misma mascota");
      else
        Console.WriteLine("No son la misma mascota");*/
      Console.ReadLine();
      
    }
  }
}
