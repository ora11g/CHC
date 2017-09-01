using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class InInvoiceDtl : EntityBase
    {
        public int Id { get; set; }
       
        public int HospId { get; set; }
       
        public int ItemId { get; set; }
       
        public System.DateTime RegOperTime { get; set; }
      
        public int RegOperId { get; set; }
       
        public int LocationId { get; set; }
       
        public int AdviceId { get; set; }
       
        public short LsMarkType { get; set; }
       
        public decimal Totality { get; set; }
       
        public decimal PriceIn { get; set; }
       
        public int UnitId { get; set; }
        
        public bool IsPay { get; set; }
       
        public decimal DiscIn { get; set; }
       
        public decimal DiscSelf { get; set; }
       
        public decimal? Amount { get; set; }
       
        public decimal AmountFact { get; set; }
       
        public decimal AmountSelf { get; set; }
      
        public decimal AmountTally { get; set; }
     
        public decimal AmountPay { get; set; }
      
        public int? InvoId { get; set; }
       
        public short LsPerform { get; set; }
       
        public bool IsModiDisc { get; set; }
     
        public int? LimitGroupId { get; set; }
       
        public decimal? LimitFee { get; set; }
       
        public int DoctorId { get; set; }
       
        public int ExecOperId { get; set; }
       
        public int ExecLocId { get; set; }
        
        public int InvItemId { get; set; }
        
        public int FeeId { get; set; }
       
        public int? FeeHsId { get; set; }
       
        public int? LsReportType { get; set; }
       
        public string Memo { get; set; }
      
        public System.DateTime OperTime { get; set; }
       
        public int OperId { get; set; }
       
        public bool IsCancel { get; set; }
       
        public int? CancelId { get; set; }
      
        public bool IsManual { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
       
        public string HostName { get; set; }
       
        public int? ExecuteId { get; set; }
       
        public string RegDate { get; set; }
    
        public int? GroupItemId { get; set; }
  
        public int? XdRpId { get; set; }
     
        public string AdviceName { get; set; }
     
        public int? MainDoctorId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public int? OuInvoId { get; set; }
        public string Urgent { get; set; }
        public string ReservedField { get; set; }
        public string ReservedField2 { get; set; }
        public decimal? PriceIn1 { get; set; }
        public decimal? PriceIn2 { get; set; }
        public int? LsPriceState { get; set; }
       
        public int? DocLocId { get; set; }
        public int? ExecDoctorId { get; set; }
	}
}
