namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kullanicis : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicis()
        {
            Logs = new HashSet<Logs>();
        }

        [Key]
        public int KullaniciID { get; set; }

        public string KullaniciAd { get; set; }

        public string KullaniciSifre { get; set; }

        public int? Personel_PersonelID { get; set; }

        public int? Yetki_YetkiID { get; set; }

        public virtual Personels Personels { get; set; }

        public virtual Yetkis Yetkis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Logs> Logs { get; set; }
    }
}
