using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class BsUserLocation : EntityBase
    {        
        public int Id { get; set; }
        ///<summary>
        /// 用户名
        ///</summary>
        public int OperId { get; set; }
        ///<summary>
        /// 所属科室
        ///</summary>
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
	}
}
