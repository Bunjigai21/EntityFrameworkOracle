//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLOYE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYE()
        {
            this.EMPLOYE1 = new HashSet<EMPLOYE>();
            this.INSCRITs = new HashSet<INSCRIT>();
        }
        public override string ToString()
        {
            return ("Employe n° : " + NUMEMP + " - Nom : " + NOMEMP );
        }
        //public override string ToString()
        //{
        //    return ("Employe n° : " + NUMEMP + " - Nom : " + NOMEMP + " - Prenom : " + PRENOMEMP);
        //} 
        public override string ToString(EMPLOYE empSalaire)
        {
            return (" Le nouveau salaire est = " + empSalaire);
        }

        public decimal NUMEMP { get; set; }
        public string NOMEMP { get; set; }
        public string PRENOMEMP { get; set; }
        public string POSTE { get; set; }
        public decimal SALAIRE { get; set; }
        public Nullable<decimal> PRIME { get; set; }
        public string CODEPROJET { get; set; }
        public Nullable<decimal> SUPERIEUR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYE> EMPLOYE1 { get; set; }
        public virtual EMPLOYE EMPLOYE2 { get; set; }
        public virtual PROJET PROJET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCRIT> INSCRITs { get; set; }
    }
}
