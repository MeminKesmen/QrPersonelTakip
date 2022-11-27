namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mesleks : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesleks()
        {
            Personels = new HashSet<Personels>();
        }

        [Key]
        public int MeslekID { get; set; }

        public string MeslekAd { get; set; }

        public int? Departman_DepartmanID { get; set; }

        public virtual Departmen Departmen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personels> Personels { get; set; }
    }
}
