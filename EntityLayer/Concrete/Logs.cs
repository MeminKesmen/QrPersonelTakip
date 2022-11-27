namespace EntityLayer.Concrete
{
    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logs : IEntity
    {
        [Key]
        public int LogID { get; set; }

        public DateTime LogTarih { get; set; }

        public string LogIslem { get; set; }

        public int? Kullanici_KullaniciID { get; set; }

        public virtual Kullanicis Kullanicis { get; set; }
    }
}
