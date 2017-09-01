using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsUser : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 用户编码
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 用户名称
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 密码
        ///</summary>
        public string Password { get; set; }
        public bool IsActive { get; set; }
        ///<summary>
        /// 原因
        ///</summary>
        public string Reason { get; set; }
        ///<summary>
        /// 默认中文输入方式：1-拼音；2-五笔
        ///</summary>
        public short LsInputWay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public bool? IsUserInputWb { get; set; }
        public bool? IsUserInputPy { get; set; }
        public bool? IsUserInputCode { get; set; }
        public bool? IsUserInputName { get; set; }
        public bool? IsUserInputStrokeCode { get; set; }
        public bool? IsUserInputEngDesc { get; set; }
        ///<summary>
        /// 介绍
        ///</summary>
        public string Introduce { get; set; }
        ///<summary>
        /// 相片文件路径
        ///</summary>
        public string PicturePath { get; set; }
        ///<summary>
        /// 地址
        ///</summary>
        public string Address { get; set; }
        ///<summary>
        /// 手机号码
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 学历编码
        ///</summary>
        public int? LevelId { get; set; }
        ///<summary>
        /// 职称
        ///</summary>
        public int? DocLevId { get; set; }
        public int? HospitalId { get; set; }
        ///<summary>
        /// 签约团队
        ///</summary>
        public int? CareGroupId { get; set; }
        public int? CareGroupId1 { get; set; }
        public string F5 { get; set; }
        public string CertIdNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public bool? IsUserInputF1 { get; set; }
        ///<summary>
        /// 用户岗位
        ///</summary>
        public int? UserLevelId { get; set; }
	}
}
