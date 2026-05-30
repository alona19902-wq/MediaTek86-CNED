using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier des motifs
    /// </summary>
    public class Motif
    {
        public int Idmotif { get; set; }
        public string Libelle { get; set; }
        
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name= "idmotif"></param>
        /// <param name= "libelle"></param>
        
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
         
        }
    }

}
