using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class InHosInfoMap : EntityTypeConfiguration<InHosInfo>
    {
        public InHosInfoMap()
            : this("dbo")
        {
        }

        public InHosInfoMap(string schema)
        {
            ToTable("InHosInfo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.HospNo).HasColumnName(@"HospNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.PatId).HasColumnName(@"PatID").IsRequired().HasColumnType("int");
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(19);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.NTime).HasColumnName(@"NTime").IsRequired().HasColumnType("int");
            Property(x => x.InTime).HasColumnName(@"InTime").IsOptional().HasColumnType("datetime");
            Property(x => x.OutTime).HasColumnName(@"OutTime").IsOptional().HasColumnType("datetime");
            Property(x => x.LsMarriage).HasColumnName(@"LsMarriage").IsOptional().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.Residence).HasColumnName(@"Residence").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.City).HasColumnName(@"City").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Province).HasColumnName(@"Province").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsOversea).HasColumnName(@"IsOversea").IsRequired().HasColumnType("bit");
            Property(x => x.PassTime).HasColumnName(@"PassTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IdCardNo).HasColumnName(@"IdCardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Company).HasColumnName(@"Company").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Occupation).HasColumnName(@"Occupation").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WorktypeId).HasColumnName(@"WorktypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.CertificateId).HasColumnName(@"CertificateId").IsOptional().HasColumnType("int");
            Property(x => x.LsInType).HasColumnName(@"LsInType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsInWay).HasColumnName(@"LsInWay").IsOptional().HasColumnType("smallint");
            Property(x => x.LsInIllness).HasColumnName(@"LsInIllness").IsOptional().HasColumnType("smallint");
            Property(x => x.DocMz).HasColumnName(@"DocMz").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.LocIn).HasColumnName(@"LocIn").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.IsYbMt).HasColumnName(@"IsYbMt").IsRequired().HasColumnType("bit");
            Property(x => x.YbRegNo).HasColumnName(@"YbRegNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ArrearAmount).HasColumnName(@"ArrearAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("decimal").HasPrecision(5,2);
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("decimal").HasPrecision(5,2);
            Property(x => x.PhoneHome).HasColumnName(@"PhoneHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeHome).HasColumnName(@"PostCodeHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeHome).HasColumnName(@"AreaCodeHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.PhoneWork).HasColumnName(@"PhoneWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressWork).HasColumnName(@"AddressWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeWork).HasColumnName(@"PostCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AreaCodeWork).HasColumnName(@"AreaCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LinkmanName).HasColumnName(@"LinkmanName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.RelationId).HasColumnName(@"RelationId").IsOptional().HasColumnType("int");
            Property(x => x.LinkmanPhone).HasColumnName(@"LinkmanPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.LinkmanAddress).HasColumnName(@"LinkmanAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LinkmanPost).HasColumnName(@"LinkmanPost").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanArea).HasColumnName(@"LinkmanArea").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LsInStatus).HasColumnName(@"LsInStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.LeaveTime).HasColumnName(@"LeaveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Status).HasColumnName(@"Status").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsEndChg).HasColumnName(@"IsEndChg").IsRequired().HasColumnType("bit");
            Property(x => x.EndChgOperId).HasColumnName(@"EndChgOperID").IsOptional().HasColumnType("int");
            Property(x => x.EndchgoperTime).HasColumnName(@"EndchgoperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AgeString).HasColumnName(@"AgeString").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.BedId).HasColumnName(@"BedId").IsOptional().HasColumnType("int");
            Property(x => x.NursingGradeId).HasColumnName(@"NursingGradeId").IsOptional().HasColumnType("int");
            Property(x => x.FirstLinkmanName).HasColumnName(@"FirstLinkmanName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.FirstRelationId).HasColumnName(@"FirstRelationId").IsOptional().HasColumnType("int");
            Property(x => x.FirstLinkmanIdCard).HasColumnName(@"FirstLinkmanIdCard").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.FirstLinkManWorkUnit).HasColumnName(@"FirstLinkManWorkUnit").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.FirstLinkmanUnitAddress).HasColumnName(@"FirstLinkmanUnitAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FirstLinkmanFamilyAddress).HasColumnName(@"FirstLinkmanFamilyAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FirstLinkmanFamilyPhone).HasColumnName(@"FirstLinkmanFamilyPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.FirstLinkmanPhone).HasColumnName(@"FirstLinkmanPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.SecondLinkmanName).HasColumnName(@"SecondLinkmanName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.SecondRelationId).HasColumnName(@"SecondRelationId").IsOptional().HasColumnType("int");
            Property(x => x.SecondLinkmanIdCard).HasColumnName(@"SecondLinkmanIdCard").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.SecondLinkManWorkUnit).HasColumnName(@"SecondLinkManWorkUnit").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.SecondLinkmanUnitAddress).HasColumnName(@"SecondLinkmanUnitAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.SecondLinkmanFamilyAddress).HasColumnName(@"SecondLinkmanFamilyAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.SecondLinkmanFamilyPhone).HasColumnName(@"SecondLinkmanFamilyPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.SecondLinkmanPhone).HasColumnName(@"SecondLinkmanPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.BedYearTypeId).HasColumnName(@"BedYearTypeId").IsOptional().HasColumnType("int");
            Property(x => x.LsOutManagementType).HasColumnName(@"LsOutManagementType").IsOptional().HasColumnType("smallint");
            Property(x => x.AddRatioId).HasColumnName(@"AddRatioId").IsOptional().HasColumnType("int");
            Property(x => x.LsEconomicSource).HasColumnName(@"LsEconomicSource").IsOptional().HasColumnType("smallint");
            Property(x => x.MealTypeId).HasColumnName(@"MealTypeId").IsOptional().HasColumnType("int");
            Property(x => x.ServiceChargeId).HasColumnName(@"ServiceChargeId").IsOptional().HasColumnType("int");
            Property(x => x.AgreementBeginDate).HasColumnName(@"AgreementBeginDate").IsOptional().HasColumnType("datetime");
            Property(x => x.AgreementEndDate).HasColumnName(@"AgreementEndDate").IsOptional().HasColumnType("datetime");
            Property(x => x.IsCheckInCharge).HasColumnName(@"IsCheckInCharge").IsRequired().HasColumnType("bit");
            Property(x => x.OneTimeFacilityFee).HasColumnName(@"OneTimeFacilityFee").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(8,4);
            Property(x => x.ServiceChargeAmount).HasColumnName(@"ServiceChargeAmount").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.BedAmount).HasColumnName(@"BedAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.NursingCost).HasColumnName(@"NursingCost").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.OldBedId).HasColumnName(@"OldBedId").IsOptional().HasColumnType("int");
            Property(x => x.RowId).HasColumnName(@"RowId").IsOptional().HasColumnType("uniqueidentifier");
		}
    }
}
