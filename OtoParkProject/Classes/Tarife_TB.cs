//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tarife_TB
    {
        public int ID { get; set; }
        public string AracTip { get; set; }
        public Nullable<int> TarifeTipId { get; set; }
        public string TarifeAd { get; set; }
        public string YıkamaTip { get; set; }
        public Nullable<decimal> YıkamaFiyat { get; set; }
        public Nullable<decimal> TarifeFiyat { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public Nullable<int> AbonelikId { get; set; }
    }
}