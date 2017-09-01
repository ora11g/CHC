using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InAdviceTempMap : EntityTypeConfiguration<InAdviceTemp>
    {
        public InAdviceTempMap()
            : this("dbo")
        {
        }

        public InAdviceTempMap(string schema)
        {
            ToTable("InAdviceTemp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AdviceTime).HasColumnName(@"AdviceTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitInId).HasColumnName(@"UnitInId").IsRequired().HasColumnType("int");
            Property(x => x.IsUrgent).HasColumnName(@"IsUrgent").IsRequired().HasColumnType("bit");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsRequired().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsRequired().HasColumnType("bit");
            Property(x => x.LsSpecialUsage).HasColumnName(@"LsSpecialUsage").IsRequired().HasColumnType("smallint");
            Property(x => x.LsExecLoc).HasColumnName(@"LsExecLoc").IsRequired().HasColumnType("smallint");
            Property(x => x.IsSkin).HasColumnName(@"IsSkin").IsRequired().HasColumnType("bit");
            Property(x => x.SkinTime).HasColumnName(@"SkinTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SkinTest).HasColumnName(@"SkinTest").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsPrinted).HasColumnName(@"IsPrinted").IsRequired().HasColumnType("bit");
            Property(x => x.IsOtherFee).HasColumnName(@"IsOtherFee").IsOptional().HasColumnType("bit");
            Property(x => x.IsChk).HasColumnName(@"IsChk").IsRequired().HasColumnType("bit");
            Property(x => x.ChkOperTime).HasColumnName(@"ChkOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.ChkOperId).HasColumnName(@"ChkOperID").IsOptional().HasColumnType("int");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsRequired().HasColumnType("bit");
            Property(x => x.AuthOperTime).HasColumnName(@"AuthOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperID").IsOptional().HasColumnType("int");
            Property(x => x.IsAuthFee).HasColumnName(@"IsAuthFee").IsRequired().HasColumnType("bit");
            Property(x => x.AuthFeeOperTime).HasColumnName(@"AuthFeeOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthFeeOperId).HasColumnName(@"AuthFeeOperID").IsOptional().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperID").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Sn).HasColumnName(@"SN").IsOptional().HasColumnType("smallint");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsRequired().HasColumnType("int");
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ExecDoctorId).HasColumnName(@"ExecDoctorId").IsOptional().HasColumnType("int");
		}
    }
}
