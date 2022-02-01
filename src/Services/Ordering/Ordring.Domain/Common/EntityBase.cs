using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordring.Domain.Common
{
   public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public string CreatedBy { get; set; }
        public string CreateedDate { get; set; }
        public string LastModify { get; set; }
        public DateTime?  LastModifiedDate{ get; set; }
    }
}
