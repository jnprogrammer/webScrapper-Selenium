//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoScrapper
{
    using System;
    using System.Collections.Generic;
    
    public partial class CryptoTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal MarketCap { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> CirculatingSupply { get; set; }
        public Nullable<decimal> Volume24Hour { get; set; }
        public Nullable<double> ChangeHour { get; set; }
        public Nullable<double> Change24Hour { get; set; }
        public Nullable<double> ChangeDay { get; set; }
        public byte[] CoinImage { get; set; }
    }
}
