using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class BsDoctorMap : EntityTypeConfiguration<BsDoctor>
    {
        public BsDoctorMap()
            : this("dbo")
        {
        }

        public BsDoctorMap(string schema)
        {
            ToTable("BsDoctor", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2);
            Property(x => x.BirthDate).HasColumnName(@"BirthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.Address).HasColumnName(@"Address").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.City).HasColumnName(@"City").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Email).HasColumnName(@"Email").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LevelId).HasColumnName(@"LevelId").IsOptional().HasColumnType("int");
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.Introduce).HasColumnName(@"Introduce").IsRequired().HasColumnType("ntext").IsMaxLength();
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeId").IsOptional().HasColumnType("int");
            Property(x => x.PicturePath).HasColumnName(@"PicturePath").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.UserId).HasColumnName(@"UserId").IsOptional().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.SupDoctorId).HasColumnName(@"SupDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.DiagRoomId).HasColumnName(@"DiagRoomID").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");

		}
    }
}
