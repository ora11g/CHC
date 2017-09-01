using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class InAdviceLong : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 开医嘱时间
        ///</summary>
        public System.DateTime? AdviceTime { get; set; }
        ///<summary>
        /// 开嘱医生
        ///</summary>
        public int DoctorId { get; set; }
        ///<summary>
        /// 开嘱科室
        ///</summary>
        public int LocationId { get; set; }
        ///<summary>
        /// 住院号（相当于门诊的流水号）,用户不可见
        ///</summary>
        public int HospId { get; set; }
        ///<summary>
        /// 组号
        ///</summary>
        public short GroupNum { get; set; }
        ///<summary>
        /// 医嘱项目
        ///</summary>
        public int ItemId { get; set; }
        ///<summary>
        /// 每次服用量
        ///</summary>
        public decimal Dosage { get; set; }
        ///<summary>
        /// 服用单位
        ///</summary>
        public int? UnitTakeId { get; set; }
        ///<summary>
        /// 每天服用次数
        ///</summary>
        public int? FrequencyId { get; set; }
        ///<summary>
        /// 用法
        ///</summary>
        public int? UsageId { get; set; }
        ///<summary>
        /// 单价
        ///</summary>
        public decimal? PriceIn { get; set; }
        ///<summary>
        /// 当天总量
        ///</summary>
        public decimal Totality { get; set; }
        ///<summary>
        /// 总量单位
        ///</summary>
        public int UnitInId { get; set; }
        ///<summary>
        /// 是否执行isNoAttach
        ///</summary>
        public bool IsAttach { get; set; }
        ///<summary>
        /// 自备药
        ///</summary>
        public bool IsSelf { get; set; }
        ///<summary>
        /// 特殊用法标志：1-静滴；2-接滴
        ///</summary>
        public short LsSpecialUsage { get; set; }
        ///<summary>
        /// 执行地点：1-西药房；2-中心药房；3-本科；4-自备药；5-记事
        ///</summary>
        public short LsExecLoc { get; set; }
        ///<summary>
        /// 是否需要皮试？
        ///</summary>
        public bool IsSkin { get; set; }
        ///<summary>
        /// 皮试时间
        ///</summary>
        public System.DateTime? SkinTime { get; set; }
        ///<summary>
        /// 皮试结果
        ///</summary>
        public string SkinTest { get; set; }
        ///<summary>
        /// 登记时间
        ///</summary>
        public System.DateTime OperTime { get; set; }
        ///<summary>
        /// 登记人
        ///</summary>
        public int OperId { get; set; }
        ///<summary>
        /// 是否已打印？
        ///</summary>
        public bool IsPrinted { get; set; }
        ///<summary>
        /// 是否已审核确认？
        ///</summary>
        public bool IsChk { get; set; }
        ///<summary>
        /// 审核确认时间
        ///</summary>
        public System.DateTime? ChkOperTime { get; set; }
        ///<summary>
        /// 审核确认护士
        ///</summary>
        public int? ChkOperId { get; set; }
        ///<summary>
        /// 是否已停止？
        ///</summary>
        public bool IsEnd { get; set; }
        public System.DateTime? EndOperTime { get; set; }
        public int? EndOperId { get; set; }
        public int? EndDoctorId { get; set; }
        ///<summary>
        /// 是否查对
        ///</summary>
        public bool IsAuth { get; set; }
        ///<summary>
        /// 最后查对时间
        ///</summary>
        public System.DateTime? AuthOperTime { get; set; }
        ///<summary>
        /// 最后查对护士
        ///</summary>
        public int? AuthOperId { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        ///<summary>
        /// 是否附加项目
        ///</summary>
        public bool? IsOtherFee { get; set; }
        ///<summary>
        /// 序号
        ///</summary>
        public short? Sn { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        ///<summary>
        /// 首日次数
        ///</summary>
        public short? FirstDay { get; set; }
        ///<summary>
        /// 末日次数
        ///</summary>
        public short? LastDay { get; set; }
        ///<summary>
        /// 执行科室
        ///</summary>
        public int ExecLocId { get; set; }
        public string F8 { get; set; }
        public int? ExecDoctorId { get; set; }
	}
}
