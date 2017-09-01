using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsPatient : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 住院号
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
        /// 病人性别：M，F，O
        ///</summary>
        public string Sex { get; set; }
        ///<summary>
        /// 生日
        ///</summary>
        public System.DateTime? BirthDate { get; set; }
        ///<summary>
        /// 婚姻状况：1-儿童；2-未婚；3-初婚；4-再婚；5-离异；6-丧偶；7-其他
        ///</summary>
        public short? LsMarriage { get; set; }
        ///<summary>
        /// 血型
        ///</summary>
        public string BloodGroup { get; set; }
        ///<summary>
        /// X光号
        ///</summary>
        public string XNo { get; set; }
        ///<summary>
        /// 民族
        ///</summary>
        public int? NationId { get; set; }
        ///<summary>
        /// 国家
        ///</summary>
        public int? CountryId { get; set; }
        ///<summary>
        /// 省
        ///</summary>
        public int? ProvinceId { get; set; }
        ///<summary>
        /// 城市
        ///</summary>
        public int? RegionId { get; set; }
        ///<summary>
        /// 区
        ///</summary>
        public int? AreaId { get; set; }
        ///<summary>
        /// 籍贯地址
        ///</summary>
        public string Native { get; set; }
        ///<summary>
        /// 户口地址
        ///</summary>
        public string Residence { get; set; }
        ///<summary>
        /// 是否外籍人士
        ///</summary>
        public bool? IsOversea { get; set; }
        ///<summary>
        /// 入境时间
        ///</summary>
        public System.DateTime? PassTime { get; set; }
        ///<summary>
        /// 工作单位
        ///</summary>
        public string Company { get; set; }
        ///<summary>
        /// 职务
        ///</summary>
        public string Occupation { get; set; }
        ///<summary>
        /// 手机号码
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 电子邮箱
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        /// 电话
        ///</summary>
        public string Phone { get; set; }
        ///<summary>
        /// 工种
        ///</summary>
        public int? WorktypeId { get; set; }
        ///<summary>
        /// 病人类别
        ///</summary>
        public int? PatTypeId { get; set; }
        ///<summary>
        /// 证件ID
        ///</summary>
        public int? CertificateId { get; set; }
        ///<summary>
        /// 过敏药物
        ///</summary>
        public string Sensitive { get; set; }
        ///<summary>
        /// 身份证号
        ///</summary>
        public string IdCardNo { get; set; }
        ///<summary>
        /// 是否婴儿
        ///</summary>
        public bool? IsBaby { get; set; }
        ///<summary>
        /// 母亲的病人ID
        ///</summary>
        public int? MotherPatId { get; set; }
        ///<summary>
        /// 医疗证号/医保号
        ///</summary>
        public string MedicareNo { get; set; }
        ///<summary>
        /// 记帐帐号
        ///</summary>
        public string AccountNo { get; set; }
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
        /// 工作单位地区号
        ///</summary>
        public string AreaCodeWork { get; set; }
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
        /// 家庭地区号
        ///</summary>
        public string AreaCodeHome { get; set; }
        ///<summary>
        /// 联系人
        ///</summary>
        public string LinkmanName { get; set; }
        ///<summary>
        /// 与联系人关系
        ///</summary>
        public int? RelationId { get; set; }
        ///<summary>
        /// 联系人邮政编码
        ///</summary>
        public string LinkmanPost { get; set; }
        ///<summary>
        /// 联系人地区号
        ///</summary>
        public string LinkmanArea { get; set; }
        ///<summary>
        /// 联系人地址
        ///</summary>
        public string LinkmanAddress { get; set; }
        ///<summary>
        /// 联系人的电话
        ///</summary>
        public string LinkmanPhone { get; set; }
        ///<summary>
        /// 所在家庭
        ///</summary>
        public int? FamilyId { get; set; }
        ///<summary>
        /// 是否户主
        ///</summary>
        public bool? IsHouseMaster { get; set; }
        ///<summary>
        /// 与户主关系
        ///</summary>
        public int? RelaMasterId { get; set; }
        ///<summary>
        /// 户籍类型:1-常住;2-暂住;3-流动
        ///</summary>
        public short? LsCensus { get; set; }
        ///<summary>
        /// 所在居委会
        ///</summary>
        public int? CommitteeId { get; set; }
        ///<summary>
        /// 所属派出所
        ///</summary>
        public int? PoliceStationId { get; set; }
        ///<summary>
        /// 学历
        ///</summary>
        public int? LevelId { get; set; }
        ///<summary>
        /// 身高(CM)
        ///</summary>
        public decimal? Height { get; set; }
        ///<summary>
        /// 体重(KG)
        ///</summary>
        public decimal? Weight { get; set; }
        ///<summary>
        /// 胸围
        ///</summary>
        public short? Circumference { get; set; }
        ///<summary>
        /// 腰围(CM)
        ///</summary>
        public short? Waistline { get; set; }
        ///<summary>
        /// 臀围(CM)
        ///</summary>
        public short? Sternline { get; set; }
        ///<summary>
        /// 体育锻炼：1-不锻炼；2-每周<3次；3-每周3次以上；4-无规律
        ///</summary>
        public short? LsSport { get; set; }
        ///<summary>
        /// 锻炼时间：1-<20分钟；2-40分钟；3-1小时以上
        ///</summary>
        public short? LsSportTime { get; set; }
        ///<summary>
        /// 锻炼类型：1-有氧运动（慢跑、气功、太极等）；2-无氧运动（速跑、篮球、排球等）
        ///</summary>
        public short? LsSportType { get; set; }
        ///<summary>
        /// 饮食习惯：1-普通；2-嗜咸；3-嗜甜；4-喜热；5-经常吃油炸食物
        ///</summary>
        public short? LsBitHabit { get; set; }
        ///<summary>
        /// 睡眠情况(小时/天)
        ///</summary>
        public short? SleepHour { get; set; }
        ///<summary>
        /// 睡眠障碍：1-无；2-入睡困难；3-早醒；4-梦游
        ///</summary>
        public short? LsSleepTrouble { get; set; }
        ///<summary>
        /// 吸烟史
        ///</summary>
        public string SmokeHistory { get; set; }
        ///<summary>
        /// 饮酒史
        ///</summary>
        public string DrinkHistory { get; set; }
        ///<summary>
        /// 其他习惯
        ///</summary>
        public string OtherHabit { get; set; }
        ///<summary>
        /// 录入时间
        ///</summary>
        public System.DateTime? OperTime { get; set; }
        ///<summary>
        /// 录入人
        ///</summary>
        public int? OperId { get; set; }
        ///<summary>
        /// 是否活动
        ///</summary>
        public bool? IsActive { get; set; }
        ///<summary>
        /// 非活动的原因
        ///</summary>
        public string InActiveReason { get; set; }
        ///<summary>
        /// 非活动(迁出或死亡)时间
        ///</summary>
        public System.DateTime? InActiveTime { get; set; }
        ///<summary>
        /// 录入非活动的操作者
        ///</summary>
        public int? InActiveOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? IconIndex { get; set; }
        
        public string PhotoFolder { get; set; }
        
        public int? RoadId { get; set; }
        
        public string PersonHistory { get; set; }
        
        public string Password { get; set; }
        
        public string HealthCardNo { get; set; }
        
        public short? LsHealthGrade { get; set; }
        
        public int? HouseholdRegisterCityId { get; set; }
        
        public int? HouseholdRegisterCountyId { get; set; }
        
        public int? HouseholdRegisterAddCountyId { get; set; }
        
        public int? HouseholdRegisterProvinceId { get; set; }
        
        public int? DomicileStreetTownId { get; set; }
        
        public string HouseholdRegisterAddress { get; set; }
        
        public string Committee { get; set; }
	}
}
