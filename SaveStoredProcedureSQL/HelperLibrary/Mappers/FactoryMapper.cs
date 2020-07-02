using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelperLibrary.Mappers
{
    public class FactoryMapper
    {
        public static Mapper CreateMapper(Profile profile)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile(profile));

            var autoMapper = new Mapper(config);

            return autoMapper;
        }
    }
}
