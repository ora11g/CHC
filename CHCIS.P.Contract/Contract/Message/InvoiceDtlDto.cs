using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xx.His.Contract.Message;

namespace CHCIS.P.Contract.Message
{
    [Serializable]
    [DataContract]
    public partial class InvoiceDtlDto : DtoBase
    {
        [DataMember(Order = 100)]
        public int HospId { get; set; }

        [DataMember(Order = 110)]
        public int ItemId { get; set; }

        [DataMember(Order = 120)]
        public System.DateTime RegOperTime { get; set; }

        [DataMember(Order = 130)]
        public int RegOperId { get; set; }

        [DataMember(Order = 140)]
        public int LocationId { get; set; }

        [DataMember(Order = 150)]
        public int AdviceId { get; set; }

        [DataMember(Order = 160)]
        public short LsMarkType { get; set; }

        [DataMember(Order = 170)]
        public decimal Totality { get; set; }

        [DataMember(Order = 180)]
        public decimal PriceIn { get; set; }

        [DataMember(Order = 190)]
        public int UnitId { get; set; }

        [DataMember(Order = 200)]
        public bool IsPay { get; set; }

        [DataMember(Order = 210)]
        public decimal DiscIn { get; set; }

        [DataMember(Order = 220)]
        public decimal DiscSelf { get; set; }

        [DataMember(Order = 230)]
        public decimal? Amount { get; set; }

        [DataMember(Order = 240)]
        public decimal AmountFact { get; set; }

        [DataMember(Order = 250)]
        public decimal AmountSelf { get; set; }

        [DataMember(Order = 260)]
        public decimal AmountTally { get; set; }

        [DataMember(Order = 270)]
        public decimal AmountPay { get; set; }

        [DataMember(Order = 280)]
        public int? InvoId { get; set; }

        [DataMember(Order = 290)]
        public short LsPerform { get; set; }

        [DataMember(Order = 300)]
        public bool IsModiDisc { get; set; }

        [DataMember(Order = 310)]
        public int? LimitGroupId { get; set; }

        [DataMember(Order = 320)]
        public decimal? LimitFee { get; set; }

        [DataMember(Order = 330)]
        public int DoctorId { get; set; }

        [DataMember(Order = 340)]
        public int ExecOperId { get; set; }

        [DataMember(Order = 350)]
        public int ExecLocId { get; set; }

        [DataMember(Order = 360)]
        public int InvItemId { get; set; }

        [DataMember(Order = 370)]
        public int FeeId { get; set; }

        [DataMember(Order = 380)]
        public int? FeeHsId { get; set; }

        [DataMember(Order = 390)]
        public int? LsReportType { get; set; }

        [DataMember(Order = 400)]
        public string Memo { get; set; }

        [DataMember(Order = 410)]
        public System.DateTime OperTime { get; set; }

        [DataMember(Order = 420)]
        public int OperId { get; set; }

        [DataMember(Order = 430)]
        public bool IsCancel { get; set; }

        [DataMember(Order = 440)]
        public int? CancelId { get; set; }

        [DataMember(Order = 450)]
        public bool IsManual { get; set; }

        [DataMember(Order = 460)]
        public string F1 { get; set; }

        [DataMember(Order = 470)]
        public string F2 { get; set; }

        [DataMember(Order = 480)]
        public string F3 { get; set; }

        [DataMember(Order = 490)]
        public string F4 { get; set; }

        [DataMember(Order = 500)]
        public string HostName { get; set; }

        [DataMember(Order = 510)]
        public int? ExecuteId { get; set; }

        [DataMember(Order = 520)]
        public string RegDate { get; set; }

        [DataMember(Order = 530)]
        public int? GroupItemId { get; set; }

        [DataMember(Order = 540)]
        public int? XdRpId { get; set; }

        [DataMember(Order = 550)]
        public string AdviceName { get; set; }

        [DataMember(Order = 560)]
        public int? MainDoctorId { get; set; }

        [DataMember(Order = 570)]
        public string F5 { get; set; }

        [DataMember(Order = 580)]
        public string F6 { get; set; }

        [DataMember(Order = 590)]
        public string F7 { get; set; }

        [DataMember(Order = 600)]
        public string F8 { get; set; }

        [DataMember(Order = 610)]
        public int? OuInvoId { get; set; }

        [DataMember(Order = 620)]
        public string Urgent { get; set; }

        [DataMember(Order = 630)]
        public string ReservedField { get; set; }

        [DataMember(Order = 640)]
        public string ReservedField2 { get; set; }

        [DataMember(Order = 650)]
        public decimal? PriceIn1 { get; set; }

        [DataMember(Order = 660)]
        public decimal? PriceIn2 { get; set; }

        [DataMember(Order = 670)]
        public int? LsPriceState { get; set; }

        [DataMember(Order = 680)]
        public int? DocLocId { get; set; }

        [DataMember(Order = 690)]
        public int? ExecDoctorId { get; set; }
    }
}
