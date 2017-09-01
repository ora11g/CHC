using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsUserLevel : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 编码
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 衣物名称
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 描述
        ///</summary>
        public string Memo { get; set; }
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 排序
        ///</summary>
        public short? OrderBy { get; set; }
        ///<summary>
        /// 可用
        ///</summary>
        public bool? IsActive { get; set; }
        ///<summary>
        /// 图标
        ///</summary>
        public int? IconIndex { get; set; }
	}
}
