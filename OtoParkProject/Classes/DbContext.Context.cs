﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtoParkProject.Classes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Abonelik_TB> Abonelik_TB { get; set; }
        public virtual DbSet<Abonelik_Tip> Abonelik_Tip { get; set; }
        public virtual DbSet<AbonelikArac_TB> AbonelikArac_TB { get; set; }
        public virtual DbSet<Aboneliks> Aboneliks { get; set; }
        public virtual DbSet<AbonelikTip_TB> AbonelikTip_TB { get; set; }
        public virtual DbSet<Arac_TB> Arac_TB { get; set; }
        public virtual DbSet<Arac_Tip> Arac_Tip { get; set; }
        public virtual DbSet<Aracs> Aracs { get; set; }
        public virtual DbSet<AracTip_TB> AracTip_TB { get; set; }
        public virtual DbSet<Cari_TB> Cari_TB { get; set; }
        public virtual DbSet<Caris> Caris { get; set; }
        public virtual DbSet<CekiciFirma_TB> CekiciFirma_TB { get; set; }
        public virtual DbSet<CekiciFirmas> CekiciFirmas { get; set; }
        public virtual DbSet<CekiciHareketleri_TB> CekiciHareketleri_TB { get; set; }
        public virtual DbSet<EhliyetBilgi_TB> EhliyetBilgi_TB { get; set; }
        public virtual DbSet<EkipPolis_TB> EkipPolis_TB { get; set; }
        public virtual DbSet<Fatura_TB> Fatura_TB { get; set; }
        public virtual DbSet<FaturaTip_TB> FaturaTip_TB { get; set; }
        public virtual DbSet<GelirTip_TB> GelirTip_TB { get; set; }
        public virtual DbSet<Gider_TB> Gider_TB { get; set; }
        public virtual DbSet<GiderTip_TB> GiderTip_TB { get; set; }
        public virtual DbSet<KasaHareketleri_TB> KasaHareketleri_TB { get; set; }
        public virtual DbSet<Odeme_TB> Odeme_TB { get; set; }
        public virtual DbSet<Personel_TB> Personel_TB { get; set; }
        public virtual DbSet<Personels> Personels { get; set; }
        public virtual DbSet<Ruhsat1_TB> Ruhsat1_TB { get; set; }
        public virtual DbSet<Ruhsat2_TB> Ruhsat2_TB { get; set; }
        public virtual DbSet<Sirketler_TB> Sirketler_TB { get; set; }
        public virtual DbSet<Sirkets> Sirkets { get; set; }
        public virtual DbSet<Subeler_TB> Subeler_TB { get; set; }
        public virtual DbSet<Subes> Subes { get; set; }
        public virtual DbSet<Surucu_TB> Surucu_TB { get; set; }
        public virtual DbSet<Tarife_TB> Tarife_TB { get; set; }
        public virtual DbSet<Tarife_Tip> Tarife_Tip { get; set; }
        public virtual DbSet<Tarifes> Tarifes { get; set; }
        public virtual DbSet<TarifeTip_TB> TarifeTip_TB { get; set; }
        public virtual DbSet<TrafikEkip_TB> TrafikEkip_TB { get; set; }
        public virtual DbSet<YediEminCikisKayit_TB> YediEminCikisKayit_TB { get; set; }
        public virtual DbSet<YediEminGirisKayit_TB> YediEminGirisKayit_TB { get; set; }
        public virtual DbSet<YediEminHasar_TB> YediEminHasar_TB { get; set; }
        public virtual DbSet<Yetki_TB> Yetki_TB { get; set; }
        public virtual DbSet<YetkiTip_TB> YetkiTip_TB { get; set; }
    }
}