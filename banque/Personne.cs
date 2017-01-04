using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    abstract class Personne
    {
        class Morale : Personne 
        {
            String raison_sociale;

            public Morale(String raison_sociale): base()
            {
                this.raison_sociale = raison_sociale;

            }
        }

        class Physique : Personne
        {
            String nom;
            String prenom;
            int revenu;

            public Physique(String nom, String prenom, int revenu) : base()
            {
                this.nom = nom;
                this.prenom = prenom;
                this.revenu = revenu;
            }

        }
    }
}
