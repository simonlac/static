using Membre_stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Membre_statique c_stats1 = new Membre_statique();
            c_stats1.numero = 10;
            Membre_statique.nb_instance += 1;
            Membre_statique c_stat2 = new Membre_statique();
            c_stat2.numero = 20;
            Membre_statique.nb_instance += 1;
            Console.Write("L'attribut statique nb_instance est égal à:"+Membre_statique)
            Membre_statique.Afficher()
        }
    }
}
