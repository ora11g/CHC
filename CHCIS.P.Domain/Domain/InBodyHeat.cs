using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class InBodyHeat : EntityBase
    {
        public int Id { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        ///<summary>
        /// 体温
        ///</summary>
        public string AnimalHeat { get; set; }
        ///<summary>
        /// 体温类型：1-口表；2-腋表；3-肛表
        ///</summary>
        public string HeatType { get; set; }
        ///<summary>
        /// 脉搏
        ///</summary>
        public string Pulse { get; set; }
        ///<summary>
        /// 心率
        ///</summary>
        public string Heart { get; set; }
        ///<summary>
        /// 呼吸
        ///</summary>
        public string Breath { get; set; }
        ///<summary>
        /// 大便次数
        ///</summary>
        public string Stool { get; set; }
        ///<summary>
        /// 小便次数
        ///</summary>
        public string Urine { get; set; }
        ///<summary>
        /// 体重
        ///</summary>
        public string Weight { get; set; }
        ///<summary>
        /// 收缩压
        ///</summary>
        public string Bldpress0 { get; set; }
        ///<summary>
        /// 舒张压
        ///</summary>
        public string Bldpress1 { get; set; }
        ///<summary>
        /// 输入液量
        ///</summary>
        public string FluidM { get; set; }
        ///<summary>
        /// 总入量
        ///</summary>
        public string TotalIn { get; set; }
        ///<summary>
        /// 尿量
        ///</summary>
        public string UrineM { get; set; }
        ///<summary>
        /// 其它排出量
        ///</summary>
        public string OtherM { get; set; }
        ///<summary>
        /// 总排出量
        ///</summary>
        public string TotalOut { get; set; }
        ///<summary>
        /// 上标注
        ///</summary>
        public string MemoUp { get; set; }
        ///<summary>
        /// 下标注
        ///</summary>
        public string MemoDn { get; set; }
        ///<summary>
        /// 皮试
        ///</summary>
        public bool SpinTest { get; set; }
        ///<summary>
        /// 物理降温
        ///</summary>
        public bool LowerTemp { get; set; }
        ///<summary>
        /// 重检
        ///</summary>
        public bool IsRecheck { get; set; }
        ///<summary>
        /// 外出
        ///</summary>
        public bool IsOutSide { get; set; }
        ///<summary>
        /// 仪器(呼吸)
        ///</summary>
        public bool IsMachine { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Others { get; set; }
        ///<summary>
        /// 是否手术
        ///</summary>
        public bool IsOps { get; set; }
        ///<summary>
        /// 分娩时间
        ///</summary>
        public System.DateTime? BirthTime { get; set; }
        ///<summary>
        /// 拒试
        ///</summary>
        public bool IsReject { get; set; }
        ///<summary>
        /// 死亡时间
        ///</summary>
        public System.DateTime? DeadTime { get; set; }
        public int? LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Bg { get; set; }
        public string CwInject { get; set; }
        public string JmInject { get; set; }
        public string CwHeight { get; set; }
        public System.DateTime? OperationTime { get; set; }
        public bool? IsLeave { get; set; }
        ///<summary>
        /// 40-42文字
        ///</summary>
        public string MemoUp1 { get; set; }
        ///<summary>
        /// 35°以下文字
        ///</summary>
        public string MemoDn1 { get; set; }
        ///<summary>
        /// 记录时间
        ///</summary>
        public System.DateTime? RecordTime { get; set; }
	}
}
