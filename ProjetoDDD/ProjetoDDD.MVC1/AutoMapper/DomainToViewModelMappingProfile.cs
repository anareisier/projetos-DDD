using ProjetoDDD.Domain.Entities;
using AutoMapper;
using ProjetoDDD.MVC1.ViewModels;

namespace ProjetoDDD.MVC1.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
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