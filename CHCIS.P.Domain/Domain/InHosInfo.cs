using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class InHosInfo : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 住院号（相当于门诊的流水号）,用户不可见
        ///</summary>
        public string HospNo { get; set; }
        ///<summary>
        /// 病人ID
        ///</summary>
        public int PatId { get; set; }
        ///<summary>
        /// 病人号(对一个病人唯一),不可见
        ///</summary>
        public string InPatNo { get; set; }
        ///<summary>
        /// 卡号
        ///</summary>
        public string CardNo { get; set; }
        ///<summary>
        /// 病人姓名
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 病人性别：F-男；M-女；O-其他
        ///</summary>
        public string Sex { get; set; }
        ///<summary>
        /// 第几次住院
        ///</summary>
        public int NTime { get; set; }
        ///<summary>
        /// 入院日期
        ///</summary>
        public System.DateTime? InTime { get; set; }
        ///<summary>
        /// 出院日期
        ///</summary>
        public System.DateTime? OutTime { get; set; }
        ///<summary>
        /// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
        ///</summary>
        public short? LsMarriage { get; set; }
        ///<summary>
        /// 血型
        ///</summary>
        public string BloodGroup { get; set; }
        ///<summary>
        /// 国家
        ///</summary>
        public int? CountryId { get; set; }
        ///<summary>
        /// 户口地址
        ///</summary>
        public string Residence { get; set; }
        ///<summary>
        /// 城市
        ///</summary>
        public string City { get; set; }
        ///<summary>
        /// 省
        ///</summary>
        public string Province { get; set; }
        ///<summary>
        /// 是否外籍人士
        ///</summary>
        public bool IsOversea { get; set; }
        ///<summary>
        /// 入境时间
        ///</summary>
        public System.DateTime? PassTime { get; set; }
        ///<summary>
        /// 身份证号
        ///</summary>
        public string IdCardNo { get; set; }
        ///<summary>
        /// 工作单位
        ///</summary>
        public string Company { get; set; }
        ///<summary>
        /// 职位
        ///</summary>
        public string Occupation { get; set; }
        ///<summary>
        /// 工种
        ///</summary>
        public int? WorktypeId { get; set; }
        ///<summary>
        /// 病人类别
        ///</summary>
        public int PatTypeId { get; set; }
        ///<summary>
        /// 证件ID
        ///</summary>
        public int? CertificateId { get; set; }
        ///<summary>
        /// 入院方式：1-门诊；2-急诊；3-转院；4-其他
        ///</summary>
        public short? LsInType { get; set; }
        ///<summary>
        /// 门诊科室
        ///</summary>
        public short? LsInWay { get; set; }
        ///<summary>
        /// 入院病情：1-危；2-急；3-一般；4-重
        ///</summary>
        public short? LsInIllness { get; set; }
        ///<summary>
        /// 门诊医生
        ///</summary>
        public int? DocMz { get; set; }
        ///<summary>
        /// 住院医生
        ///</summary>
        public int? DoctorId { get; set; }
        ///<summary>
        /// 入院科室
        ///</summary>
        public int LocIn { get; set; }
        ///<summary>
        /// 当前科室
        ///</summary>
        public int? LocationId { get; set; }
        ///<summary>
        /// 是否门特病人
        ///</summary>
        public bool IsYbMt { get; set; }
        ///<summary>
        /// 医保就医登记号
        ///</summary>
        public string YbRegNo { get; set; }
        ///<summary>
        /// 欠费多少就限制录入费用(备用金)
        ///</summary>
        public decimal? ArrearAmount { get; set; }
        ///<summary>
        /// 身高
        ///</summary>
        public decimal? Height { get; set; }
        ///<summary>
        /// 体重
        ///</summary>
        public decimal? Weight { get; set; }
        ///<summary>
        /// 家庭的电话
        ///</summary>
        public string PhoneHome { get; set; }
        ///<summary>
        /// 家庭地址
        ///</summary>
        public string AddressHome { get; set; }
        ///<summary>
        /// 家庭的邮政编码
        ///</summary>
        public string PostCodeHome { get; set; }
        ///<summary>
        /// 工作单位地区号
        ///</summary>
        public string AreaCodeHome { get; set; }
        ///<summary>
        /// 工作单位的电话
        ///</summary>
        public string PhoneWork { get; set; }
        ///<summary>
        /// 工作单位地址
        ///</summary>
        public string AddressWork { get; set; }
        ///<summary>
        /// 工作单位的邮政编码
        ///</summary>
        public string PostCodeWork { get; set; }
        ///<summary>
        /// 家庭地区号
        ///</summary>
        public string AreaCodeWork { get; set; }
        ///<summary>
        /// 联系人姓名
        ///</summary>
        public string LinkmanName { get; set; }
        ///<summary>
        /// 联系人关系
        ///</summary>
        public int? RelationId { get; set; }
        ///<summary>
        /// 联系人电话
        ///</summary>
        public string LinkmanPhone { get; set; }
        ///<summary>
        /// 联系人地址
        ///</summary>
        public string LinkmanAddress { get; set; }
        ///<summary>
        /// 联系人邮政编码
        ///</summary>
        public string LinkmanPost { get; set; }
        ///<summary>
        /// 联系人地区号
        ///</summary>
        public string LinkmanArea { get; set; }
        ///<summary>
        /// 住院状态：1-等待住院；2-在院；3-出院；4-请假；5-待出院；6-预约
        ///</summary>
        public short LsInStatus { get; set; }
        ///<summary>
        /// 请假日期
        ///</summary>
        public System.DateTime? LeaveTime { get; set; }
        ///<summary>
        /// 住院病情
        ///</summary>
        public string Status { get; set; }
        ///<summary>
        /// 登记日期
        ///</summary>
        public System.DateTime OperTime { get; set; }
        ///<summary>
        /// 登记人
        ///</summary>
        public int OperId { get; set; }
        ///<summary>
        /// 结束收费标志
        ///</summary>
        public bool IsEndChg { get; set; }
        ///<summary>
        /// 结束收费人
        ///</summary>
        public int? EndChgOperId { get; set; }
        ///<summary>
        /// 结束收费时间
        ///</summary>
        public System.DateTime? EndchgoperTime { get; set; }
        ///<summary>
        /// 年龄描述
        ///</summary>
        public string AgeString { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 当前床位
        ///</summary>
        public int? BedId { get; set; }
        ///<summary>
        /// 护理等级
        ///</summary>
        public int? NursingGradeId { get; set; }
        public string FirstLinkmanName { get; set; }
        public int? FirstRelationId { get; set; }
        public string FirstLinkmanIdCard { get; set; }
        public string FirstLinkManWorkUnit { get; set; }
        public string FirstLinkmanUnitAddress { get; set; }
        public string FirstLinkmanFamilyAddress { get; set; }
        public string FirstLinkmanFamilyPhone { get; set; }
        public string FirstLinkmanPhone { get; set; }
        public string SecondLinkmanName { get; set; }
        public int? SecondRelationId { get; set; }
        public string SecondLinkmanIdCard { get; set; }
        public string SecondLinkManWorkUnit { get; set; }
        public string SecondLinkmanUnitAddress { get; set; }
        public string SecondLinkmanFamilyAddress { get; set; }
        public string SecondLinkmanFamilyPhone { get; set; }
        public string SecondLinkmanPhone { get; set; }
        ///<summary>
        /// 入住年制
        ///</summary>
        public int? BedYearTypeId { get; set; }
        ///<summary>
        /// 外出管理类型：1-经担保人（或家属）同意 2-可自由出入
        ///</summary>
        public short? LsOutManagementType { get; set; }
        ///<summary>
        /// 加收标准Id
        ///</summary>
        public int? AddRatioId { get; set; }
        ///<summary>
        /// 经济来源：1-退休金/养老金 2-子女补贴 3-亲友资助 4-其他
        ///</summary>
        public short? LsEconomicSource { get; set; }
        ///<summary>
        /// 膳食标准
        ///</summary>
        public int? MealTypeId { get; set; }
        ///<summary>
        /// 服务费
        ///</summary>
        public int? ServiceChargeId { get; set; }
        ///<summary>
        /// 协议开始日期
        ///</summary>
        public System.DateTime? AgreementBeginDate { get; set; }
        ///<summary>
        /// 协议结束日期
        ///</summary>
        public System.DateTime? AgreementEndDate { get; set; }
        ///<summary>
        /// 入住期初收费标志 1:已收费
        ///</summary>
        public bool IsCheckInCharge { get; set; }
        ///<summary>
        /// 一次性生活设施费
        ///</summary>
        public decimal? OneTimeFacilityFee { get; set; }
        ///<summary>
        /// 折扣
        ///</summary>
        public decimal? Discount { get; set; }
        ///<summary>
        /// 服务费
        ///</summary>
        public decimal? ServiceChargeAmount { get; set; }
        ///<summary>
        /// 床位费
        ///</summary>
        public decimal? BedAmount { get; set; }
        ///<summary>
        /// 服务费
        ///</summary>
        public decimal? NursingCost { get; set; }
        public int? OldBedId { get; set; }
        /// <summary>
        /// 长者IdentityId
        /// </summary>
        public Guid RowId { get; set; }
	}
}
