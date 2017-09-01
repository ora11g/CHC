using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsNursingGrade : EntityBase
    {
        public int Id { get; set; }
        ///<summary>
        /// 药库ID
        ///</summary>
        public string Code { get; set; }
        ///<summary>
        /// 药库
        ///</summary>
        public string Name { get; set; }
        public int? ItemId { get; set; }
        ///<summary>
        /// 退费起始天数
        ///</summary>
        public short BackDays { get; set; }
        ///<summary>
        /// 五笔码
        ///</summary>
        public string WbCode { get; set; }
        ///<summary>
        /// 拼音码
        ///</summary>
        public string PyCode { get; set; }
        ///<summary>
        /// 显示顺序
        ///</summary>
        public short OrderBy { get; set; }
        ///<summary>
        /// 有效标志
        ///</summary>
        public bool IsActive { get; set; }
        ///<summary>
        /// 住院价格
        ///</summary>
        public decimal PriceIn { get; set; }
        public int SubsidyGradeId { get; set; }
	}
}
