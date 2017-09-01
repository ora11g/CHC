using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsDoctor : EntityBase
    {

        public int Id { get; set; }

        ///<summary>
        /// 内码
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 中文名
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 性别
        ///</summary>
        public string Sex { get; set; }
        ///<summary>
        /// 出生日期
        ///</summary>
        public System.DateTime? BirthDate { get; set; }
        ///<summary>
        /// 地址
        ///</summary>
        public string Address { get; set; }
        ///<summary>
        /// 城市
        ///</summary>
        public string City { get; set; }
        ///<summary>
        /// 手机号码
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// email
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        /// 学历编码
        ///</summary>
        public int? LevelId { get; set; }
        ///<summary>
        /// 职称
        ///</summary>
        public int? DocLevId { get; set; }
        ///<summary>
        /// 介绍
        ///</summary>
        public string Introduce { get; set; }
        ///<summary>
        /// 所属科室
        ///</summary>
        public int? LocationId { get; set; }
        ///<summary>
        /// 门诊类别
        ///</summary>
        public int? RegTypeId { get; set; }
        ///<summary>
        /// 相片文件路径
        ///</summary>
        public string PicturePath { get; set; }
        ///<summary>
        /// 在职离职状态：1-在职；2-离职
        ///</summary>
        public short LsStatus { get; set; }
        ///<summary>
        /// 显示排序
        ///</summary>
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public int? UserId { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 上级医生
        ///</summary>
        public int? SupDoctorId { get; set; }
        public int? DiagRoomId { get; set; }
        public System.DateTime? OperTime { get; set; }
	}
}
