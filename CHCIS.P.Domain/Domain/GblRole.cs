using System;
using System.Collections.Generic;
using Xx.His.Domain;

namespace CHCIS.P.Domain
{
    public partial class GblRole : EntityBase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
	}
}
