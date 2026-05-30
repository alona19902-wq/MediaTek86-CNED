using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier des service
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name= "idservice"></param>
        /// <param name= "nom"></param>
       
        public Service (int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        
        }

        public int Idservice { get; set; }
        public string Nom { get; set; }
        
    }
}
