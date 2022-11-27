using EntityLayer.Concrete;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class PersonelTakipDBContext : DbContext
    {
        public PersonelTakipDBContext()
            : base("name=PersonelTakipDBCon")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            
        }
      

        public virtual DbSet<Departmen> Departmen { get; set; }
        public virtual DbSet<Islems> Islems { get; set; }
        public virtual DbSet<Izins> Izins { get; set; }
        public virtual DbSet<Kullanicis> Kullanicis { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Mesleks> Mesleks { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yetkis> Yetkis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departmen>()
                .HasMany(e => e.Mesleks)
                .WithOptional(e => e.Departmen)
                .HasForeignKey(e => e.Departman_DepartmanID);

            modelBuilder.Entity<Kullanicis>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.Kullanicis)
                .HasForeignKey(e => e.Kullanici_KullaniciID);

            modelBuilder.Entity<Mesleks>()
                .HasMany(e => e.Personels)
                .WithOptional(e => e.Mesleks)
                .HasForeignKey(e => e.Meslek_MeslekID);

            modelBuilder.Entity<Personels>()
                .HasMany(e => e.Islems)
                .WithOptional(e => e.Personels)
                .HasForeignKey(e => e.Personel_PersonelID);

            modelBuilder.Entity<Personels>()
                .HasMany(e => e.Izins)
                .WithOptional(e => e.Personels)
                .HasForeignKey(e => e.Personel_PersonelID);

            modelBuilder.Entity<Personels>()
                .HasMany(e => e.Kullanicis)
                .WithOptional(e => e.Personels)
                .HasForeignKey(e => e.Personel_PersonelID);

            modelBuilder.Entity<Yetkis>()
                .HasMany(e => e.Kullanicis)
                .WithOptional(e => e.Yetkis)
                .HasForeignKey(e => e.Yetki_YetkiID);
        }
    }
}
