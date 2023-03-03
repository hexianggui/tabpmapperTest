using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Motest.TEST
{
    public class MapperTestAppService : TESTAppService, IMapperTestAppService
    {
        private readonly IRepository<MapperTest, Guid> _repository;
        public MapperTestAppService(IRepository<MapperTest, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<MapperDto> GetAsync()
        {
            var entity = await _repository.FirstOrDefaultAsync();
            return ObjectMapper.Map<MapperTest, MapperDto>(entity);
        }
        public async Task<MapperDto> CreateAsync(MapperCreateDto input)
        {
            var entity = ObjectMapper.Map<MapperCreateDto, MapperTest>(input);
            entity = await _repository.InsertAsync(entity, true);
            return ObjectMapper.Map<MapperTest, MapperDto>(entity);
        }
    }
}
