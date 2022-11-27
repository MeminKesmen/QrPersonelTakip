namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Izins : IEntity
    {
        [Key]
        public int IzinID { get; set; }

        public DateTime IzinBaslangic { get; set; }

        public DateTime IzinBitis { get; set; }

        public int? Personel_PersonelID { get; set; }

        public virtual Personels Personels { get; set; }
    }
}
