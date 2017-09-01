using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InExecuteMap : EntityTypeConfiguration<InExecute>
    {
        public InExecuteMap()
            : this("dbo")
        {
        }

        public InExecuteMap(string schema)
        {
            ToTable("InExecute", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.PrintOperTime).HasColumnName(@"PrintOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PrintOperId).HasColumnName(@"PrintOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AdviceTime).HasColumnName(@"AdviceTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("smallint");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitInId).HasColumnName(@"UnitInId").IsOptional().HasColumnType("int");
            Property(x => x.IsUrgent).HasColumnName(@"IsUrgent").IsOptional().HasColumnType("bit");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsOptional().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsOptional().HasColumnType("bit");
            Property(x => x.LsSpecialUsage).HasColumnName(@"LsSpecialUsage").IsOptional().HasColumnType("smallint");
            Property(x => x.LsExecLoc).HasColumnName(@"LsExecLoc").IsOptional().HasColumnType("smallint");
            Property(x => x.IsSkin).HasColumnName(@"IsSkin").IsOptional().HasColumnType("bit");
            Property(x => x.SkinTime).HasColumnName(@"SkinTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SkinTest).HasColumnName(@"SkinTest").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.IsExecuted).HasColumnName(@"IsExecuted").IsOptional().HasColumnType("bit");
            Property(x => x.ExecutedTime).HasColumnName(@"ExecutedTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExecutedOperId).HasColumnName(@"ExecutedOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsMinus).HasColumnName(@"IsMinus").IsOptional().HasColumnType("bit");
            Property(x => x.NurseMemo).HasColumnName(@"NurseMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.MemoTime).HasColumnName(@"MemoTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.MemoOperId).HasColumnName(@"MemoOperId").IsOptional().HasColumnType("int");
            Property(x => x.FirstDay).HasColumnName(@"FirstDay").IsOptional().HasColumnType("smallint");
            Property(x => x.LastDay).HasColumnName(@"LastDay").IsOptional().HasColumnType("smallint");
            Property(x => x.IsLastLong).HasColumnName(@"IsLastLong").IsOptional().HasColumnType("bit");
            Property(x => x.IsArrearage).HasColumnName(@"IsArrearage").IsOptional().HasColumnType("bit");
		}
    }
}
