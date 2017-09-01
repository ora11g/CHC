using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class InAdviceTemp : EntityBase
    {
        public int Id { get; set; }
      
        public System.DateTime? AdviceTime { get; set; }
              
        public int DoctorId { get; set; }
            
        public int LocationId { get; set; }        
      
        public int HospId { get; set; }
      
        public short GroupNum { get; set; }
      
        public int ItemId { get; set; }
              
        public decimal Dosage { get; set; }
                
        public int? UnitTakeId { get; set; }
        
        public int? FrequencyId { get; set; }
        
        public int? UsageId { get; set; }
        
        public decimal PriceIn { get; set; }
        
        public short? Days { get; set; }
        
        public decimal Totality { get; set; }
        
        public int UnitInId { get; set; }
        
        public bool IsUrgent { get; set; }
        
        public bool IsAttach { get; set; }
  
        public bool IsSelf { get; set; }
      
        public short LsSpecialUsage { get; set; }
              
        public short LsExecLoc { get; set; }
     
        public bool IsSkin { get; set; }
       
        public System.DateTime? SkinTime { get; set; }
       
        public string SkinTest { get; set; }
        
        public System.DateTime OperTime { get; set; }
      
        public int OperId { get; set; }
      
        public bool IsPrinted { get; set; }
        
        public bool? IsOtherFee { get; set; }
      
        public bool IsChk { get; set; }
       
        public System.DateTime? ChkOperTime { get; set; }
       
        public int? ChkOperId { get; set; }
       
        public bool IsAuth { get; set; }
       
        public System.DateTime? AuthOperTime { get; set; }
        
        public int? AuthOperId { get; set; }
       
        public bool IsAuthFee { get; set; }
      
        public System.DateTime? AuthFeeOperTime { get; set; }
       
        public int? AuthFeeOperId { get; set; }
       
        public bool IsCancel { get; set; }
       
        public System.DateTime? CancelOperTime { get; set; }
       
        public int? CancelOperId { get; set; }
       
        public string Memo { get; set; }
        public string F1 { get; set; }

        public string F2 { get; set; }

        public string F3 { get; set; }

        public string F4 { get; set; }
        
        public short? Sn { get; set; }
        
        public string F5 { get; set; }
        
        public string F6 { get; set; }
        
        public string F7 { get; set; }
        
        public int ExecLocId { get; set; }
        
        public string F8 { get; set; }
        
        public int? ExecDoctorId { get; set; }
	}
}
