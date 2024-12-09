using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using URF.Core.EF.Trackable.Entities;

namespace URF.Core.EF.Trackable
{
    public class BaseEntity : SqlTenantEntity
    {
        [IgnoreDataMember]
        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }

        [IgnoreDataMember]
        [ForeignKey("UpdatedBy")]
        public virtual User UpdatedByUser { get; set; }
    }
}
