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
    
    public partial class tblJeu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblJeu()
        {
            this.tblClassification = new HashSet<tblClassification>();
            this.tblGenre = new HashSet<tblGenre>();
            this.tblPlateforme = new HashSet<tblPlateforme>();
            this.tblTheme = new HashSet<tblTheme>();
        }
    
        public int idJeu { get; set; }
        public string nomJeu { get; set; }
        public string devellopeurJeu { get; set; }
        public string descriptionJeu { get; set; }
        public string configurationMinimaleJeu { get; set; }
        public Nullable<int> idProjetTest { get; set; }
        public string tag { get; set; }
    
        public virtual tblProjetTest tblProjetTest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblClassification> tblClassification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGenre> tblGenre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPlateforme> tblPlateforme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTheme> tblTheme { get; set; }
    }
}