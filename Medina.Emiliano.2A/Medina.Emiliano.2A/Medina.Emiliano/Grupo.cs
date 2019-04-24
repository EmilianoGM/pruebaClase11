using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medina.Emiliano
{
  public class Grupo
  {
    private List<Mascota> _manada;
    private string _nombre;
    static EtipoManada _tipo;

    public EtipoManada Tipo
    {
      set { _tipo = value; }
    }

    static Grupo()
    {
      _tipo = EtipoManada.Unica;
    }

    private Grupo()
    {
      this._manada = new List<Mascota>();
    }

    public Grupo(string nombre) : this()
    {
      this._nombre = nombre;
    }

    public Grupo(string nombre, EtipoManada tipo) : this(nombre)
    {
      this.Tipo = tipo;
    }

    public static bool operator ==(Grupo grupo, Mascota mascota)
    {
      return grupo._manada.Contains(mascota);
    }

    public static bool operator !=(Grupo grupo, Mascota mascota)
    {
      return !(grupo == mascota);
    }

    public static Grupo operator +(Grupo grupo, Mascota mascota)
    {
      if(grupo != mascota)
      {
        grupo._manada.Add(mascota);
      } else
      {
        Console.WriteLine("Ya esta el " + mascota.ToString() + " en el grupo");
      }
      return grupo;
    }

    public static Grupo operator -(Grupo grupo, Mascota mascota)
    {
      if (grupo == mascota)
      {
        grupo._manada.Remove(mascota);
      } else
      {
        Console.WriteLine("No esta el " + mascota.ToString() + " en el grupo");
      }
      return grupo;
    }

    public static implicit operator string(Grupo grupo)
    {
      string retorno = "Grupo: " + grupo._nombre + " - tipo: " + Grupo._tipo.ToString() + "\nIntegrantes (" + grupo._manada.Count().ToString() + "):\n";
      foreach(Mascota mascota in grupo._manada)
      {
        retorno += mascota.ToString() + "\n";
      }
      return retorno;
    }
  }
}
