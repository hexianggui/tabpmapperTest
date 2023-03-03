using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Motest.TEST
{
    public class MapperDto : EntityDto<Guid>
    {
        public List<string> Images { get; set; }
    }
}
