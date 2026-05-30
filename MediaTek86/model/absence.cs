using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier des abcences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name= "idpersonnel"></param>
        /// <param name= "datedebut"></param>
        /// <param name= "datefin"></param>
        /// <param name= "idmotif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Idmotif = idmotif;
        }

        public int Idpersonnel { get; set; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public int Idmotif { get; set; }



    }
}
