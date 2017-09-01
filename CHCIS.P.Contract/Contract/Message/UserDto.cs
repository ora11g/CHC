using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xx.His.Contract.Message;

namespace CHCIS.P.Contract.Message
{
    public partial class UserDto : DtoBase
    {
        [DataMember(Order = 100)]
        public string Code { get; set; }

        [DataMember(Order = 110)]
        public string Name { get; set; }

        [DataMember(Order = 120)]
        public string Password { get; set; }

        [DataMember(Order = 130)]
        public bool IsActive { get; set; }

        [DataMember(Order = 140)]
        public string Reason { get; set; }

        [DataMember(Order = 150)]
        public short LsInputWay { get; set; }

        [DataMember(Order = 160)]
        public string F1 { get; set; }

        [DataMember(Order = 170)]
        public string F2 { get; set; }

        [DataMember(Order = 180)]
        public string F3 { get; set; }

        [DataMember(Order = 190)]
        public string F4 { get; set; }

        [DataMember(Order = 200)]
        public short IconIndex { get; set; }

        [DataMember(Order = 210)]
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
