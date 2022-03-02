using AutoMapper;
using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.Domain.Models.ValueObjects;

namespace PurchaseMS.Infrastructure.Profiles
{
    public class DomainModelToDTOProfile : Profile
    {
        public DomainModelToDTOProfile()
        {
            CreateMap<Purchase, ReadPurchaseDTO>();
            CreateMap<PurchaseItem, ReadPurchaseItemDTO>();
            CreateMap<Buyer, ReadBuyerDTO>();
            CreateMap<Address, ReadAddressDTO>();
        }
    }
}