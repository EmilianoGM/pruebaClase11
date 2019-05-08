using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medina.Emiliano
{
  public class Perro : Mascota
  {
    private int edad;
    private bool esAlfa;

    public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
    {

    }

    public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
    {
      this.edad = edad;
      this.esAlfa = esAlfa;
    }

    protected override string Ficha()
    {
      string retorno;
      if (this.esAlfa)
      {
        retorno = this.DatosCompletos() + ", alfa de la manada, edad " + this.edad;
      } else
      {
        retorno = this.DatosCompletos() + ", edad " + this.edad;
      }
      return retorno;
    }

    public static bool operator ==(Perro perroUno, Perro perroDos)
    {
      bool retorno = false;
      if(Object.Equals(perroUno, null) && Object.Equals(perroDos, null))
      {
        retorno = true;
      } else if (!(Object.Equals(perroUno, null) && Object.Equals(perroDos, null)))
      {
        if (perroUno.Nombre.Equals(perroDos.Nombre) && perroUno.Raza.Equals(perroDos.Raza) && perroUno.edad == perroDos.edad)
        {
          retorno = true;
        }
      }
      return retorno;
    }
    public static bool operator !=(Perro perroUno, Perro perroDos)
    {
      return !(perroUno == perroDos);
    }
    public static explicit operator int(Perro perro)
    {
      return perro.edad;
    }

    public override bool Equals(object obj)
    {
      if (obj is Perro)
      {
        return (Perro)(obj) == this;
      }
      else
      {
        return false;
      }
    }

    public override string ToString()
    {
      return this.Ficha();
    }
  }
}
