﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KalipServiceWCF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KalipDBEntities : DbContext
    {
        public KalipDBEntities()
            : base("name=KalipDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Numune> Numune { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<NumuneDetay> NumuneDetay { get; set; }
    
        public virtual ObjectResult<procPieChart_Result> procPieChart(Nullable<System.DateTime> pBaslangic, Nullable<System.DateTime> pBitis, Nullable<int> pUrunKodu, Nullable<int> pKalipKodu)
        {
            var pBaslangicParameter = pBaslangic.HasValue ?
                new ObjectParameter("pBaslangic", pBaslangic) :
                new ObjectParameter("pBaslangic", typeof(System.DateTime));
    
            var pBitisParameter = pBitis.HasValue ?
                new ObjectParameter("pBitis", pBitis) :
                new ObjectParameter("pBitis", typeof(System.DateTime));
    
            var pUrunKoduParameter = pUrunKodu.HasValue ?
                new ObjectParameter("pUrunKodu", pUrunKodu) :
                new ObjectParameter("pUrunKodu", typeof(int));
    
            var pKalipKoduParameter = pKalipKodu.HasValue ?
                new ObjectParameter("pKalipKodu", pKalipKodu) :
                new ObjectParameter("pKalipKodu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procPieChart_Result>("procPieChart", pBaslangicParameter, pBitisParameter, pUrunKoduParameter, pKalipKoduParameter);
        }
    
        public virtual ObjectResult<procPieChartOnlyDate_Result> procPieChartOnlyDate(Nullable<System.DateTime> pBaslangic, Nullable<System.DateTime> pBitis)
        {
            var pBaslangicParameter = pBaslangic.HasValue ?
                new ObjectParameter("pBaslangic", pBaslangic) :
                new ObjectParameter("pBaslangic", typeof(System.DateTime));
    
            var pBitisParameter = pBitis.HasValue ?
                new ObjectParameter("pBitis", pBitis) :
                new ObjectParameter("pBitis", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procPieChartOnlyDate_Result>("procPieChartOnlyDate", pBaslangicParameter, pBitisParameter);
        }
    
        public virtual ObjectResult<prcPieChart_Result> prcPieChart(Nullable<System.DateTime> pBaslangic, Nullable<System.DateTime> pBitis, Nullable<int> pUrunKodu, Nullable<int> pKalipKodu)
        {
            var pBaslangicParameter = pBaslangic.HasValue ?
                new ObjectParameter("pBaslangic", pBaslangic) :
                new ObjectParameter("pBaslangic", typeof(System.DateTime));
    
            var pBitisParameter = pBitis.HasValue ?
                new ObjectParameter("pBitis", pBitis) :
                new ObjectParameter("pBitis", typeof(System.DateTime));
    
            var pUrunKoduParameter = pUrunKodu.HasValue ?
                new ObjectParameter("pUrunKodu", pUrunKodu) :
                new ObjectParameter("pUrunKodu", typeof(int));
    
            var pKalipKoduParameter = pKalipKodu.HasValue ?
                new ObjectParameter("pKalipKodu", pKalipKodu) :
                new ObjectParameter("pKalipKodu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prcPieChart_Result>("prcPieChart", pBaslangicParameter, pBitisParameter, pUrunKoduParameter, pKalipKoduParameter);
        }
    
        public virtual ObjectResult<prcPieChartOnlyDate_Result> prcPieChartOnlyDate(Nullable<System.DateTime> pBaslangic, Nullable<System.DateTime> pBitis)
        {
            var pBaslangicParameter = pBaslangic.HasValue ?
                new ObjectParameter("pBaslangic", pBaslangic) :
                new ObjectParameter("pBaslangic", typeof(System.DateTime));
    
            var pBitisParameter = pBitis.HasValue ?
                new ObjectParameter("pBitis", pBitis) :
                new ObjectParameter("pBitis", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prcPieChartOnlyDate_Result>("prcPieChartOnlyDate", pBaslangicParameter, pBitisParameter);
        }
    }
}
