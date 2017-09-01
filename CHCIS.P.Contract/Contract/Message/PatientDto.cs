using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xx.His.Contract.Message;

namespace CHCIS.P.Contract.Message
{
    [Serializable]
    [DataContract]
    public partial class PatientDto : DtoBase
    {        
        //[DataMember(Order = 1)]
        //public int Id { get; set; }

        [DataMember(Order = 10)]
        public string CardNo { get; set; }

        [DataMember(Order = 20)]
        public string Name { get; set; }

        [DataMember(Order = 30)]
        public string Sex { get; set; }

        [DataMember(Order = 40)]
        public System.DateTime? BirthDate { get; set; }

        [DataMember(Order = 50)]
        public short? LsMarriage { get; set; }

        [DataMember(Order = 60)]
        public int? NationId { get; set; }

        [DataMember(Order = 70)]
        public int? CountryId { get; set; }

        [DataMember(Order = 80)]
        public int? ProvinceId { get; set; }

        [DataMember(Order = 90)]
        public int? RegionId { get; set; }

        [DataMember(Order = 100)]
        public int? AreaId { get; set; }

        [DataMember(Order = 110)]
        public string Native { get; set; }

        [DataMember(Order = 120)]
        public string Residence { get; set; }

        [DataMember(Order = 130)]
        public string Company { get; set; }

        [DataMember(Order = 140)]
        public string Occupation { get; set; }

        [DataMember(Order = 150)]
        public string Mobile { get; set; }

        [DataMember(Order = 160)]
        public string Email { get; set; }

        [DataMember(Order = 170)]
        public string Phone { get; set; }

        [DataMember(Order = 180)]
        public int? WorktypeId { get; set; }

        [DataMember(Order = 190)]
        public int? PatTypeId { get; set; }

        [DataMember(Order = 200)]
        public int? CertificateId { get; set; }

        [DataMember(Order = 210)]
        public string Sensitive { get; set; }

        [DataMember(Order = 220)]
        public string IdCardNo { get; set; }

        [DataMember(Order = 230)]
        public bool? IsBaby { get; set; }

        [DataMember(Order = 240)]
        public int? MotherPatId { get; set; }

        [DataMember(Order = 250)]
        public string MedicareNo { get; set; }

        [DataMember(Order = 260)]
        public string AccountNo { get; set; }

        [DataMember(Order = 270)]
        public string PhoneWork { get; set; }

        [DataMember(Order = 280)]
        public string AddressWork { get; set; }

        [DataMember(Order = 290)]
        public string PostCodeWork { get; set; }

        [DataMember(Order = 300)]
        public string PhoneHome { get; set; }

        [DataMember(Order = 310)]
        public string AddressHome { get; set; }

        [DataMember(Order = 320)]
        public string LinkmanName { get; set; }

        [DataMember(Order = 330)]
        public int? RelationId { get; set; }

        [DataMember(Order = 340)]
        public string LinkmanAddress { get; set; }

        [DataMember(Order = 350)]
        public string LinkmanPhone { get; set; }

        [DataMember(Order = 360)]
        public int? FamilyId { get; set; }

        [DataMember(Order = 370)]
        public int? LevelId { get; set; }

        [DataMember(Order = 380)]
        public decimal? Height { get; set; }

        [DataMember(Order = 390)]
        public decimal? Weight { get; set; }

        [DataMember(Order = 400)]
        public short? LsBitHabit { get; set; }

        [DataMember(Order = 410)]
        public short? SleepHour { get; set; }

        [DataMember(Order = 420)]
        public short? LsSleepTrouble { get; set; }

        [DataMember(Order = 430)]
        public System.DateTime? OperTime { get; set; }

        [DataMember(Order = 440)]
        public int? OperId { get; set; }

        [DataMember(Order = 450)]
        public bool? IsActive { get; set; }

        [DataMember(Order = 460)]
        public short? IconIndex { get; set; }

        [DataMember(Order = 470)]
        public string PersonHistory { get; set; }

        [DataMember(Order = 480)]
        public int CloudPatientID { get; set; }
	}
}
