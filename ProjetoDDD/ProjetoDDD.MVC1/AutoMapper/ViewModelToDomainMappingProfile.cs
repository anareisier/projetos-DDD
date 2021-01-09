using AutoMapper;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.MVC1.ViewModels;


namespace ProjetoDDD.MVC1.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}