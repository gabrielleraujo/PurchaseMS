using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.Domain.Models.Entities;

namespace PurchaseMS.DomainService.Mappers
{
    public interface ICustomMapper
    {
        Purchase Map(CreatePurchaseDTO purchase);
        ReadPurchaseDTO Map(Purchase purchase);
        IList<ReadPurchaseDTO> Map(IList<Purchase> purchases);
    }
}