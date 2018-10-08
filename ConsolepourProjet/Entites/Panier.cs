using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTest.Entites
{
    public class Panier
    {
        public Panier()
        {
            this.Lignes = new List<LignePanier>();
        }

        public List<LignePanier> Lignes { get; set; }

        public decimal GetTotal()
        {
            if (!this.Lignes.Any())
            {
                return 0;
            }

            var totalLignes = this.Lignes.Sum(x => x.Produit.Prix * x.Quantite);
            var fraisPort = totalLignes > 100 ? 0 : 10;
            return totalLignes + fraisPort;
        }

        public void Valider()
        {
            foreach (var ligne in this.Lignes)
            {
                ligne.Valider();
            }
        }
    }
}