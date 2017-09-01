using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InBodyHeatMap : EntityTypeConfiguration<InBodyHeat>
    {
        public InBodyHeatMap()
            : this("dbo")
        {
        }

        public InBodyHeatMap(string schema)
        {
            ToTable("InBodyHeat", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.AnimalHeat).HasColumnName(@"AnimalHeat").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HeatType).HasColumnName(@"HeatType").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Pulse).HasColumnName(@"Pulse").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Heart).HasColumnName(@"Heart").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Breath).HasColumnName(@"Breath").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Stool).HasColumnName(@"Stool").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Urine).HasColumnName(@"Urine").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Weight).HasColumnName(@"Weight").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bldpress0).HasColumnName(@"Bldpress0").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bldpress1).HasColumnName(@"Bldpress1").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FluidM).HasColumnName(@"FluidM").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TotalIn).HasColumnName(@"TotalIn").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UrineM).HasColumnName(@"UrineM").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OtherM).HasColumnName(@"OtherM").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TotalOut).HasColumnName(@"TotalOut").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MemoUp).HasColumnName(@"MemoUp").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MemoDn).HasColumnName(@"MemoDn").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SpinTest).HasColumnName(@"SpinTest").IsRequired().HasColumnType("bit");
            Property(x => x.LowerTemp).HasColumnName(@"LowerTemp").IsRequired().HasColumnType("bit");
            Property(x => x.IsRecheck).HasColumnName(@"IsRecheck").IsRequired().HasColumnType("bit");
            Property(x => x.IsOutSide).HasColumnName(@"IsOutSide").IsRequired().HasColumnType("bit");
            Property(x => x.IsMachine).HasColumnName(@"IsMachine").IsRequired().HasColumnType("bit");
            Property(x => x.Others).HasColumnName(@"Others").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsOps).HasColumnName(@"IsOps").IsRequired().HasColumnType("bit");
            Property(x => x.BirthTime).HasColumnName(@"BirthTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsReject).HasColumnName(@"IsReject").IsRequired().HasColumnType("bit");
            Property(x => x.DeadTime).HasColumnName(@"DeadTime").IsOptional().HasColumnType("datetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Bg).HasColumnName(@"BG").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.CwInject).HasColumnName(@"CwInject").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.JmInject).HasColumnName(@"JmInject").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CwHeight).HasColumnName(@"CwHeight").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperationTime).HasColumnName(@"OperationTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsLeave).HasColumnName(@"IsLeave").IsOptional().HasColumnType("bit");
            Property(x => x.MemoUp1).HasColumnName(@"MemoUp1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MemoDn1).HasColumnName(@"MemoDn1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecordTime).HasColumnName(@"RecordTime").IsOptional().HasColumnType("datetime");
		}
    }
}
