using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InInvoiceDtlMap : EntityTypeConfiguration<InInvoiceDtl>
    {
        public InInvoiceDtlMap()
            : this("dbo")
        {
        }

        public InInvoiceDtlMap(string schema)
        {
            ToTable("InInvoiceDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.RegOperTime).HasColumnName(@"RegOperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.RegOperId).HasColumnName(@"RegOperId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.IsPay).HasColumnName(@"IsPay").IsRequired().HasColumnType("bit");
            Property(x => x.DiscIn).HasColumnName(@"DiscIn").IsRequired().HasColumnType("decimal").HasPrecision(8,4);
            Property(x => x.DiscSelf).HasColumnName(@"DiscSelf").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.AmountFact).HasColumnName(@"AmountFact").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountSelf).HasColumnName(@"AmountSelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountTally).HasColumnName(@"AmountTally").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
            Property(x => x.LsPerform).HasColumnName(@"LsPerform").IsRequired().HasColumnType("smallint");
            Property(x => x.IsModiDisc).HasColumnName(@"IsModiDisc").IsRequired().HasColumnType("bit");
            Property(x => x.LimitGroupId).HasColumnName(@"LimitGroupId").IsOptional().HasColumnType("int");
            Property(x => x.LimitFee).HasColumnName(@"LimitFee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.ExecOperId).HasColumnName(@"ExecOperId").IsRequired().HasColumnType("int");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsRequired().HasColumnType("int");
            Property(x => x.InvItemId).HasColumnName(@"InvItemId").IsRequired().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsRequired().HasColumnType("int");
            Property(x => x.FeeHsId).HasColumnName(@"FeeHsId").IsOptional().HasColumnType("int");
            Property(x => x.LsReportType).HasColumnName(@"LsReportType").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelId).HasColumnName(@"CancelId").IsOptional().HasColumnType("int");
            Property(x => x.IsManual).HasColumnName(@"IsManual").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.HostName).HasColumnName(@"HostName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsOptional().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.GroupItemId).HasColumnName(@"GroupItemId").IsOptional().HasColumnType("int");
            Property(x => x.XdRpId).HasColumnName(@"XDRpId").IsOptional().HasColumnType("int");
            Property(x => x.AdviceName).HasColumnName(@"AdviceName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MainDoctorId).HasColumnName(@"MainDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OuInvoId).HasColumnName(@"OuInvoId").IsOptional().HasColumnType("int");
            Property(x => x.Urgent).HasColumnName(@"Urgent").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.ReservedField).HasColumnName(@"ReservedField").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.ReservedField2).HasColumnName(@"ReservedField2").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.PriceIn1).HasColumnName(@"PriceIn1").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.PriceIn2).HasColumnName(@"PriceIn2").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.LsPriceState).HasColumnName(@"LsPriceState").IsOptional().HasColumnType("int");
            Property(x => x.DocLocId).HasColumnName(@"DocLocId").IsOptional().HasColumnType("int");
            Property(x => x.ExecDoctorId).HasColumnName(@"ExecDoctorId").IsOptional().HasColumnType("int");

		}
    }
}
