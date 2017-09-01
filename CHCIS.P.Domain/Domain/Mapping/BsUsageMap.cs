using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class BsUsageMap : EntityTypeConfiguration<BsUsage>
    {
        public BsUsageMap()
            : this("dbo")
        {
        }

        public BsUsageMap(string schema)
        {
            ToTable("BsUsage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PrintName).HasColumnName(@"PrintName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.LsUseArea).HasColumnName(@"LsUseArea").IsRequired().HasColumnType("smallint");
            Property(x => x.LsPrnFormType).HasColumnName(@"LsPrnFormType").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPrintLabel).HasColumnName(@"IsPrintLabel").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintReject).HasColumnName(@"IsPrintReject").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintDrug).HasColumnName(@"IsPrintDrug").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintAst).HasColumnName(@"IsPrintAst").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintCure).HasColumnName(@"IsPrintCure").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintNurse).HasColumnName(@"IsPrintNurse").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintExternal).HasColumnName(@"IsPrintExternal").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintPush).HasColumnName(@"IsPrintPush").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintRejSkin).HasColumnName(@"IsPrintRejSkin").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintDietetic).HasColumnName(@"IsPrintDietetic").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrintBlood).HasColumnName(@"IsPrintBlood").IsRequired().HasColumnType("bit");
            Property(x => x.IsMzDrop).HasColumnName(@"IsMzDrop").IsRequired().HasColumnType("bit");
            Property(x => x.IsMzReject).HasColumnName(@"IsMzReject").IsRequired().HasColumnType("bit");
            Property(x => x.IsMzCure).HasColumnName(@"IsMzCure").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPrintAtomization).HasColumnName(@"IsPrintAtomization").IsOptional().HasColumnType("bit");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsInOutType).HasColumnName(@"LsInOutType").IsOptional().HasColumnType("int");
            Property(x => x.IsDrugTwoDay).HasColumnName(@"IsDrugTwoDay").IsOptional().HasColumnType("bit");
		}
    }
}
