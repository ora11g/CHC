using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsRelation : EntityBase
    {      
        public int Id { get; set; }
        ///<summary>
        /// 关系ID
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 与病人关系
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 有效标志
        ///</summary>
        public bool IsActive { get; set; }
        ///<summary>
        /// 显示顺序
        ///</summary>
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
	}
}
