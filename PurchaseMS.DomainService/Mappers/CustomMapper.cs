using AutoMapper;
using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.DomainService.Mappers
{
    public class CustomMapper : ICustomMapper
    {
        private readonly IMapper _mapper;
        public CustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Purchase Map(CreatePurchaseDTO purchase)
        {
            return _mapper.Map<Purchase>(purchase);
        }

        public ReadPurchaseDTO Map(Purchase purchase)
        {
            var dto = _mapper.Map<ReadPurchaseDTO>(purchase);
            dto.Status = GetStateAsString(purchase);
            return dto;
        }

        public IList<ReadPurchaseDTO> Map(IList<Purchase> purchases)
        {
            var dtos = new List<ReadPurchaseDTO>();
            for(int i = 0; i < purchases.Count; i++)
            {
                dtos.Add(Map(purchases[i]));
            }
            return dtos;
        }

        public static string GetStateAsString(Purchase model) => model.State.GetType().Name;
    }
}