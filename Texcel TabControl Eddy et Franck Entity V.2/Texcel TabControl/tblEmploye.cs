//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Texcel_TabControl
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmploye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmploye()
        {
            this.tblCategorieEmploi = new HashSet<tblCategorieEmploi>();
            this.tblEquipe = new HashSet<tblEquipe>();
        }
    
        public int idEmploye { get; set; }
        public string nomEmploye { get; set; }
        public string prenomEmploye { get; set; }
        public System.DateTime dateDeNaissanceEmploye { get; set; }
        public string adresseligne1Employe { get; set; }
        public string adresseligne2Employe { get; set; }
        public string codePostalEmploye { get; set; }
        public string telephoneResidenceEmploye { get; set; }
        public string posteTelephoniqueEmploye { get; set; }
        public string matriculeEmploye { get; set; }
        public int idVille { get; set; }
    
        public virtual tblGerant tblGerant { get; set; }
        public virtual tblVille tblVille { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCategorieEmploi> tblCategorieEmploi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEquipe> tblEquipe { get; set; }
    }
}
