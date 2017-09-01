using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsUsage : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 用法编号
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 用法
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 打印/显示名
        ///</summary>
        public string PrintName { get; set; }
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 适用范围：1-门诊；2-住院；3-共用
        ///</summary>
        public short LsUseArea { get; set; }
        ///<summary>
        /// 药房分类单打印类别：1-口服药单；2-针剂汇总单
        ///</summary>
        public short LsPrnFormType { get; set; }
        ///<summary>
        /// 是否打印瓶签
        ///</summary>
        public bool IsPrintLabel { get; set; }
        ///<summary>
        /// 是否打印注射单
        ///</summary>
        public bool IsPrintReject { get; set; }
        ///<summary>
        /// 是否打印服药单
        ///</summary>
        public bool IsPrintDrug { get; set; }
        ///<summary>
        /// 是否打印AST单
        ///</summary>
        public bool IsPrintAst { get; set; }
        ///<summary>
        /// 是否打印治疗单
        ///</summary>
        public bool IsPrintCure { get; set; }
        ///<summary>
        /// 是否打印护理单
        ///</summary>
        public bool IsPrintNurse { get; set; }
        ///<summary>
        /// 是否打印外用单
        ///</summary>
        public bool IsPrintExternal { get; set; }
        ///<summary>
        /// 是否打印静推单
        ///</summary>
        public bool IsPrintPush { get; set; }
        ///<summary>
        /// 是否打印皮下注射单
        ///</summary>
        public bool IsPrintRejSkin { get; set; }
        ///<summary>
        /// 是否打印饮食单
        ///</summary>
        public bool IsPrintDietetic { get; set; }
        ///<summary>
        /// 是否打印测血压单
        ///</summary>
        public bool IsPrintBlood { get; set; }
        ///<summary>
        /// 是否打印门诊输液单
        ///</summary>
        public bool IsMzDrop { get; set; }
        ///<summary>
        /// 是否打印门诊注射单
        ///</summary>
        public bool IsMzReject { get; set; }
        ///<summary>
        /// 是否打印门诊治疗单
        ///</summary>
        public bool IsMzCure { get; set; }
        ///<summary>
        /// 显示顺序
        ///</summary>
        public short OrderBy { get; set; }
        ///<summary>
        /// 有效标志
        ///</summary>
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public bool? IsPrintAtomization { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public int? LsInOutType { get; set; }
        public bool? IsDrugTwoDay { get; set; }
	}
}
