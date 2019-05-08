using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaList
{
  public class Elemento
  {
    public int numero;
    public string palabra;
    public Elemento(int numero, string palabra)
    {
      this.numero = numero;
      this.palabra = palabra;
    }
    public override string ToString()
    {
      return numero.ToString() + " - " + palabra;
    }
  }
}
