using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Motest.TEST
{
    public class MapperTest:Entity<Guid>
    {
        public string Images { get; set; }
    }
}
