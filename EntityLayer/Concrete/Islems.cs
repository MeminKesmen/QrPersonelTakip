namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Islems : IEntity
    {
        public Islems()
        {
            IslemTarih = DateTime.Now;
        }
        [Key]
        public int IslemID { get; set; }

        public bool IslemAd { get; set; }

        public DateTime IslemTarih { get; set; }

        public int? Personel_PersonelID { get; set; }

        public virtual Personels Personels { get; set; }
    }
}
