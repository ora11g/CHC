using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class BsPatientMap : EntityTypeConfiguration<BsPatient>
    {
        public BsPatientMap()
            : this("dbo")
        {
            ConfigProperties();
        }

        public BsPatientMap(string schema)
        {
            ToTable("BsPatient", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(19);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.BirthDate).HasColumnName(@"BirthDate").IsOptional().HasColumnType("datetime");
            Property(x => x.LsMarriage).HasColumnName(@"LsMarriage").IsOptional().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.XNo).HasColumnName(@"XNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.NationId).HasColumnName(@"NationId").IsOptional().HasColumnType("int");
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.ProvinceId).HasColumnName(@"ProvinceId").IsOptional().HasColumnType("int");
            Property(x => x.RegionId).HasColumnName(@"RegionId").IsOptional().HasColumnType("int");
            Property(x => x.AreaId).HasColumnName(@"AreaId").IsOptional().HasColumnType("int");
            Property(x => x.Native).HasColumnName(@"Native").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Residence).HasColumnName(@"Residence").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsOversea).HasColumnName(@"IsOversea").IsOptional().HasColumnType("bit");
            Property(x => x.PassTime).HasColumnName(@"PassTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Company).HasColumnName(@"Company").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Occupation).HasColumnName(@"Occupation").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Email).HasColumnName(@"Email").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.WorktypeId).HasColumnName(@"WorktypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.CertificateId).HasColumnName(@"CertificateId").IsOptional().HasColumnType("int");
            Property(x => x.Sensitive).HasColumnName(@"Sensitive").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IdCardNo).HasColumnName(@"IdCardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsBaby).HasColumnName(@"isBaby").IsOptional().HasColumnType("bit");
            Property(x => x.MotherPatId).HasColumnName(@"MotherPatId").IsOptional().HasColumnType("int");
            Property(x => x.MedicareNo).HasColumnName(@"MedicareNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(18);
            Property(x => x.AccountNo).HasColumnName(@"AccountNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.PhoneWork).HasColumnName(@"PhoneWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressWork).HasColumnName(@"AddressWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeWork).HasColumnName(@"PostCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeWork).HasColumnName(@"AreaCodeWork").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.PhoneHome).HasColumnName(@"PhoneHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PostCodeHome).HasColumnName(@"PostCodeHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeHome).HasColumnName(@"AreaCodeHome").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.LinkmanName).HasColumnName(@"LinkmanName").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.RelationId).HasColumnName(@"RelationId").IsOptional().HasColumnType("int");
            Property(x => x.LinkmanPost).HasColumnName(@"LinkmanPost").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanArea).HasColumnName(@"LinkmanArea").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LinkmanAddress).HasColumnName(@"LinkmanAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LinkmanPhone).HasColumnName(@"LinkmanPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.FamilyId).HasColumnName(@"FamilyId").IsOptional().HasColumnType("int");
            Property(x => x.IsHouseMaster).HasColumnName(@"isHouseMaster").IsOptional().HasColumnType("bit");
            Property(x => x.RelaMasterId).HasColumnName(@"RelaMasterId").IsOptional().HasColumnType("int");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsOptional().HasColumnType("smallint");
            Property(x => x.CommitteeId).HasColumnName(@"CommitteeId").IsOptional().HasColumnType("int");
            Property(x => x.PoliceStationId).HasColumnName(@"PoliceStationId").IsOptional().HasColumnType("int");
            Property(x => x.LevelId).HasColumnName(@"LevelId").IsOptional().HasColumnType("int");
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("decimal").HasPrecision(5,2);
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("decimal").HasPrecision(5,2);
            Property(x => x.Circumference).HasColumnName(@"Circumference").IsOptional().HasColumnType("smallint");
            Property(x => x.Waistline).HasColumnName(@"Waistline").IsOptional().HasColumnType("smallint");
            Property(x => x.Sternline).HasColumnName(@"Sternline").IsOptional().HasColumnType("smallint");
            Property(x => x.LsSport).HasColumnName(@"LsSport").IsOptional().HasColumnType("smallint");
            Property(x => x.LsSportTime).HasColumnName(@"LsSportTime").IsOptional().HasColumnType("smallint");
            Property(x => x.LsSportType).HasColumnName(@"LsSportType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsBitHabit).HasColumnName(@"LsBitHabit").IsOptional().HasColumnType("smallint");
            Property(x => x.SleepHour).HasColumnName(@"SleepHour").IsOptional().HasColumnType("smallint");
            Property(x => x.LsSleepTrouble).HasColumnName(@"LsSleepTrouble").IsOptional().HasColumnType("smallint");
            Property(x => x.SmokeHistory).HasColumnName(@"SmokeHistory").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.DrinkHistory).HasColumnName(@"DrinkHistory").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OtherHabit).HasColumnName(@"OtherHabit").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
            Property(x => x.PhotoFolder).HasColumnName(@"PhotoFolder").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RoadId).HasColumnName(@"RoadId").IsOptional().HasColumnType("int");
            Property(x => x.PersonHistory).HasColumnName(@"PersonHistory").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HealthCardNo).HasColumnName(@"HealthCardNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LsHealthGrade).HasColumnName(@"LsHealthGrade").IsOptional().HasColumnType("smallint");
            Property(x => x.HouseholdRegisterCityId).HasColumnName(@"HouseholdRegisterCityId").IsOptional().HasColumnType("int");
            Property(x => x.HouseholdRegisterCountyId).HasColumnName(@"HouseholdRegisterCountyId").IsOptional().HasColumnType("int");
            Property(x => x.HouseholdRegisterAddCountyId).HasColumnName(@"HouseholdRegisterAddCountyId").IsOptional().HasColumnType("int");
            Property(x => x.HouseholdRegisterProvinceId).HasColumnName(@"HouseholdRegisterProvinceId").IsOptional().HasColumnType("int");
            Property(x => x.DomicileStreetTownId).HasColumnName(@"DomicileStreetTownId").IsOptional().HasColumnType("int");
            Property(x => x.HouseholdRegisterAddress).HasColumnName(@"HouseholdRegisterAddress").IsOptional().HasColumnType("nvarchar").HasMaxLength(250);
            Property(x => x.Committee).HasColumnName(@"Committee").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);            
		}
    }
}
