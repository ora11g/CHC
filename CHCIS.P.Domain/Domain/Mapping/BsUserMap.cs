using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class BsUserMap : EntityTypeConfiguration<BsUser>
    {
        public BsUserMap()
            : this("dbo")
        {
        }

        public BsUserMap(string schema)
        {
            ToTable("BsUser", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Password).HasColumnName(@"Password").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.Reason).HasColumnName(@"Reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.LsInputWay).HasColumnName(@"LsInputWay").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsUserInputWb).HasColumnName(@"IsUserInputWB").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputPy).HasColumnName(@"IsUserInputPY").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputCode).HasColumnName(@"IsUserInputCode").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputName).HasColumnName(@"IsUserInputName").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputStrokeCode).HasColumnName(@"IsUserInputStrokeCode").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputEngDesc).HasColumnName(@"IsUserInputEngDesc").IsOptional().HasColumnType("bit");
            Property(x => x.Introduce).HasColumnName(@"Introduce").IsOptional().HasColumnType("ntext").IsMaxLength();
            Property(x => x.PicturePath).HasColumnName(@"PicturePath").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.LevelId).HasColumnName(@"LevelId").IsOptional().HasColumnType("int");
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.CareGroupId).HasColumnName(@"CareGroupId").IsOptional().HasColumnType("int");
            Property(x => x.CareGroupId1).HasColumnName(@"CareGroupId1").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CertIdNo).HasColumnName(@"CertIdNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.IsUserInputF1).HasColumnName(@"IsUserInputF1").IsOptional().HasColumnType("bit");
            Property(x => x.UserLevelId).HasColumnName(@"UserLevelId").IsOptional().HasColumnType("int");
		}
    }
}
