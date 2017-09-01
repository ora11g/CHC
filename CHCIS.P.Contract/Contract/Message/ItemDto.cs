using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xx.His.Contract.Message;

namespace CHCIS.P.Contract.Message
{
    [Serializable]
    [DataContract]
    public partial class ItemDto : DtoBase
    {
        [DataMember(Order = 1100)]
        public short LsGroupType { get; set; }

        [DataMember(Order = 1200)]
        public string Code { get; set; }

        [DataMember(Order = 1300)]
        public string WbCode { get; set; }

        [DataMember(Order = 1400)]
        public string PyCode { get; set; }

        [DataMember(Order = 1500)]
        public string StrokeCode { get; set; }

        [DataMember(Order = 1600)]
        public string OtherCode { get; set; }

        [DataMember(Order = 1700)]
        public int GroupMainId { get; set; }

        [DataMember(Order = 1800)]
        public int? GroupSubId { get; set; }

        [DataMember(Order = 1900)]
        public string Name { get; set; }

        [DataMember(Order = 2000)]
        public string LongDesc { get; set; }

        [DataMember]
        public string EngDesc { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public decimal PriceIn { get; set; }

        [DataMember]
        public int UnitDiagId { get; set; }

        [DataMember]
        public decimal PriceDiag { get; set; }

        [DataMember]
        public decimal AddPercent { get; set; }

        [DataMember]
        public short LsRpType { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int FeeMzId { get; set; }

        [DataMember]
        public short LsGfType { get; set; }

        [DataMember]
        public int TypeGfxeId { get; set; }

        [DataMember]
        public bool IsOnlyForSys { get; set; }

        [DataMember]
        public bool IsRpForbid { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]        
        public short? OrderBy { get; set; }        
    }
}
