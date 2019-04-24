using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medina.Emiliano
{
  public class Gato : Mascota
  {
    public Gato(string nombre, string raza) : base(nombre, raza)
    {

    }

    protected override string Ficha()
    {
      return this.DatosCompletos();
    }

    public static bool operator ==(Gato gatoUno, Gato gatoDos)
    {
      if (gatoUno.Nombre.Equals(gatoDos.Nombre) && gatoUno.Raza.Equals(gatoDos.Raza))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Gato gatoUno, Gato gatoDos)
    {
      return !(gatoUno == gatoDos);
    }

    public override string ToString()
    {
      return this.Ficha();
    }

    public override bool Equals(object obj)
    {
      if(obj is Gato)
      {
        return (Gato)(obj) == this;
      } else
      {
        return false;
      }
    }
  }
}
