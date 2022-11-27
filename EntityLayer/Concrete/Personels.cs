namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personels : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personels()
        {
            Islems = new HashSet<Islems>();
            Izins = new HashSet<Izins>();
            Kullanicis = new HashSet<Kullanicis>();
            PersonelIseGiris = DateTime.Now;
            PersonelDurum = true;
        }

        [Key]
        public int PersonelID { get; set; }

        public string PersonelAd { get; set; }

        public string PersonelSoyad { get; set; }

        public string PersonelTC { get; set; }

        public string PersonelTel { get; set; }

        public string PersonelAdres { get; set; }

        public decimal PersonelMaas { get; set; }

        public DateTime PersonelDogumTarih { get; set; }

        public string PersonelMail { get; set; }

        public string PersonelQR { get; set; }

        public string PersonelResim { get; set; }

        public bool PersonelDurum { get; set; }

        public DateTime PersonelIseGiris { get; set; }

        public int? Meslek_MeslekID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Islems> Islems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izins> Izins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanicis> Kullanicis { get; set; }

        public virtual Mesleks Mesleks { get; set; }
    }
}
