using PurchaseMS.CrossCutting.Dtos;

namespace PurchaseMS.DomainService.Interfaces
{
    public interface IPurchaseDomainService
    {
        Task<double> CalculateDiscount(CreatePurchaseDTO purchaseDto);
        Task<double> CalculateTotalPrice(CreatePurchaseDTO purchaseDto, double otherValues);
        Task ApplyDiscount(CreatePurchaseDTO purchaseDto);
        Task<ReadPurchaseDTO> AddAsync(CreatePurchaseDTO purchaseDto);

        Task<ReadPurchaseDTO> GetByIdAsync(int id);
        Task<IList<ReadPurchaseDTO>> ListAsync();

        Task<IList<ReadPurchaseDTO>> ListIncludingAsync();
        Task<ReadPurchaseDTO> GetByIdIncludingAsync(int id);
    }
}