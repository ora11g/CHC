using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsItem : EntityBase
    {
        ///<summary>
        /// 项目ID
        ///</summary>
        public int Id { get; set; }
        ///<summary>
        /// 项目分类：1-药品；2-治疗；3-物资材料
        ///</summary>
        public short LsGroupType { get; set; }
        ///<summary>
        /// 编码
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 五笔码（固定）
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 拼音码（固定）
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 化学名五笔码
        ///</summary>
        public string StrokeCode { get; set; }
        ///<summary>
        /// 化学名拼音码
        ///</summary>
        public string OtherCode { get; set; }
        ///<summary>
        /// 主组
        ///</summary>
        public int GroupMainId { get; set; }
        ///<summary>
        /// 子组
        ///</summary>
        public int? GroupSubId { get; set; }
        ///<summary>
        /// 简称
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 全称
        ///</summary>
        public string LongDesc { get; set; }
        ///<summary>
        /// 英文名
        ///</summary>
        public string EngDesc { get; set; }
        ///<summary>
        /// 规格
        ///</summary>
        public string Spec { get; set; }
        ///<summary>
        /// 住院单位
        ///</summary>
        public int UnitInId { get; set; }
        ///<summary>
        /// 住院价格
        ///</summary>
        public decimal PriceIn { get; set; }
        ///<summary>
        /// 门诊单位
        ///</summary>
        public int UnitDiagId { get; set; }
        ///<summary>
        /// 门诊价格
        ///</summary>
        public decimal PriceDiag { get; set; }
        ///<summary>
        /// 加成率
        ///</summary>
        public decimal AddPercent { get; set; }
        ///<summary>
        /// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-
        ///</summary>
        public short LsRpType { get; set; }
        ///<summary>
        /// 用量
        ///</summary>
        public decimal Dosage { get; set; }
        ///<summary>
        /// 服用单位
        ///</summary>
        public int? UnitTakeId { get; set; }
        ///<summary>
        /// 频率
        ///</summary>
        public int? FrequencyId { get; set; }
        ///<summary>
        /// 用法
        ///</summary>
        public int? UsageId { get; set; }
        ///<summary>
        /// 门诊收费类别
        ///</summary>
        public int FeeMzId { get; set; }
        ///<summary>
        /// 住院收费类别
        ///</summary>
        public int FeeZyId { get; set; }
        ///<summary>
        /// 公费类别：1-公费；2-自费；3-按固定自付比例
        ///</summary>
        public short LsGfType { get; set; }
        ///<summary>
        /// 固定的自付比例
        ///</summary>
        public decimal? GfFixDisc { get; set; }
        ///<summary>
        /// 是否允许在结算时修改单价
        ///</summary>
        public bool OptionPrice { get; set; }
        ///<summary>
        /// 单位剂量
        ///</summary>
        public decimal LimitTotalMz { get; set; }
        ///<summary>
        /// 住院计价最小用量
        ///</summary>
        public decimal LimitTotalZy { get; set; }
        ///<summary>
        /// 公费限额类别
        ///</summary>
        public int TypeGfxeId { get; set; }
        ///<summary>
        /// 是否特别统计（150元以上）
        ///</summary>
        public bool IsSpecSum { get; set; }
        public bool IsNew { get; set; }
        ///<summary>
        /// 医院内部使用的项目
        ///</summary>
        public bool IsOnlyForSys { get; set; }
        ///<summary>
        /// 禁止临床开药
        ///</summary>
        public bool IsRpForbid { get; set; }
        ///<summary>
        /// 是否儿科加收20%
        ///</summary>
        public bool IsChildAdd { get; set; }
        ///<summary>
        /// 是否床位费
        ///</summary>
        public bool IsBedFee { get; set; }
        ///<summary>
        /// 是否加收布类费用
        ///</summary>
        public bool IsOpsAdd { get; set; }
        ///<summary>
        /// 限制使用地点：1-全部;2-门诊;3-住院(原意义：长期医嘱附加收费的周期：1-每次收费；2-每天收费；3-每周收费)
        ///</summary>
        public short LsfeeTurn { get; set; }
        ///<summary>
        /// 医嘱类别：1-医嘱；2-附加收费
        ///</summary>
        public short LsAdviceType { get; set; }
        ///<summary>
        /// 执行科室
        ///</summary>
        public int? LocationId { get; set; }
        ///<summary>
        /// EASILAB的PRICES表的对应CODE
        ///</summary>
        public int? LisCode { get; set; }
        ///<summary>
        /// 封面图片
        ///</summary>
        public string CoverPicture { get; set; }
        ///<summary>
        /// 说明书扫描图
        ///</summary>
        public string MemoPicture { get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Memo { get; set; }
        ///<summary>
        /// 有效标志
        ///</summary>
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        ///<summary>
        /// 按小时计费
        ///</summary>
        public bool? IsInoculate { get; set; }
        ///<summary>
        /// 最高零售价
        ///</summary>
        public decimal? PriceHighLine { get; set; }
        ///<summary>
        /// 显示顺序
        ///</summary>
        public short? OrderBy { get; set; }
        ///<summary>
        /// 三级分组
        ///</summary>
        public int? GroupSubId2 { get; set; }
        ///<summary>
        /// 输入时间
        ///</summary>
        public System.DateTime? LastTime { get; set; }
        ///<summary>
        /// 一级医院价格
        ///</summary>
        public decimal? PriceSub { get; set; }
        ///<summary>
        /// 对应基本检查
        ///</summary>
        public int? CheckId { get; set; }
        ///<summary>
        /// 对应基本护理
        ///</summary>
        public int? NurseId { get; set; }
        ///<summary>
        /// 对应基本治疗
        ///</summary>
        public int? CureId { get; set; }
        ///<summary>
        /// 药典ID
        ///</summary>
        public int? DrugId { get; set; }
        public int? CopyId { get; set; }
        ///<summary>
        /// 门诊计价最小用量
        ///</summary>
        public int? MzUnitTotal { get; set; }
        public int? ZyUnitTotal { get; set; }
        ///<summary>
        /// 是否门特用药
        ///</summary>
        public bool? IsMtDrug { get; set; }
        public string PackageSpec { get; set; }
        ///<summary>
        /// 是否市基
        ///</summary>
        public bool IsCitySum { get; set; }
	}
}
