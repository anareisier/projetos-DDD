using AutoMapper;

namespace ProjetoDDD.MVC1.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {

            var mappingConfig = new MapperConfiguration(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
            /*
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();

            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });*/
        }


    }
}