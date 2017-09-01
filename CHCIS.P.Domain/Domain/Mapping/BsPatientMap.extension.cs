using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHCIS.P.Domain.Mapping
{
    public partial class BsPatientMap : EntityTypeConfiguration<BsPatient>
    {
        public void ConfigProperties()
        {
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
        }
    }
}
