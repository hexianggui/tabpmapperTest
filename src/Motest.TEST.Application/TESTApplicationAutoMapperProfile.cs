using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Motest.TEST;

public class TESTApplicationAutoMapperProfile : Profile
{
    public static List<string> StringSplit(string p)
    {
        if (p.IsNullOrWhiteSpace())
        {
            return new List<string>();
        }
        return p.Split(",").ToList();
    }
    public TESTApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<MapperTest, MapperDto>()
            .ForMember(d => d.Images, o => o.MapFrom(s => StringSplit(s.Images)));
        CreateMap<MapperCreateDto, MapperTest>(MemberList.Source)
           .ForMember(d => d.Images, o => o.MapFrom(s => string.Join(",", s.Images)));
    }
}
