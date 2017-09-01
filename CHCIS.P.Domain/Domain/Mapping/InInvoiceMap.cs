using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InInvoiceMap : EntityTypeConfiguration<InInvoice>
    {
        public InInvoiceMap()
            : this("dbo")
        {
        }

        public InInvoiceMap(string schema)
        {
            ToTable("InInvoice", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.LsPayType).HasColumnName(@"LsPayType").IsRequired().HasColumnType("smallint");
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.FromDate).HasColumnName(@"FromDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ToDate).HasColumnName(@"ToDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ChargeDays).HasColumnName(@"ChargeDays").IsRequired().HasColumnType("smallint");
            Property(x => x.Beprice).HasColumnName(@"Beprice").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.TallyNo).HasColumnName(@"TallyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FactGet).HasColumnName(@"FactGet").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Insurance).HasColumnName(@"Insurance").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PaySelf).HasColumnName(@"PaySelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Deposit).HasColumnName(@"Deposit").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Complement).HasColumnName(@"Complement").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Arrearage).HasColumnName(@"Arrearage").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AddFee).HasColumnName(@"AddFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Remark).HasColumnName(@"Remark").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperID").IsOptional().HasColumnType("int");
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.InvoLastId).HasColumnName(@"InvoLastId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.YbIllId).HasColumnName(@"YbIllId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelCheckTime).HasColumnName(@"CancelCheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.ReAmount).HasColumnName(@"ReAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ReAmountDate).HasColumnName(@"ReAmountDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ReAmountMemo).HasColumnName(@"ReAmountMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);

		}
    }
}
