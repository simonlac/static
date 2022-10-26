using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membre_stat
{



  class Membre_statique
  {/// <summary>
  /// aFFICHE UN message
  /// </summary>

    public int numero;
    public static int nb_instance = 0;

    public static void Afficher()
    {
        Console.WriteLine("\nJe suis une méthode statique.");
    }
    public static void incrementer()
    {
        nb_instance++;
        Console.WriteLine("Le nombre d'objets instanciés est égal à" + nb_instance);
    }
    
    }
  }

