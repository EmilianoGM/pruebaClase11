using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medina.Emiliano
{
  public abstract class Mascota
  {
    private string _nombre;

    public string Nombre
    {
      get { return this._nombre; }
    }

    private string _raza;

    public string Raza
    {
      get { return this._raza; }
    }

    public Mascota(string nombre, string raza)
    {
      this._nombre = nombre;
      this._raza = raza;
    }

    protected virtual string DatosCompletos()
    {
      return this._nombre + " " + this._raza;
    }

    protected abstract string Ficha();


  }
}
