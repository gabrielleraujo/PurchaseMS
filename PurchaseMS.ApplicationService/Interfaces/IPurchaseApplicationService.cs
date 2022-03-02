using PurchaseMS.CrossCutting.Dtos;

namespace PurchaseMS.ApplicationService.Interfaces
{
    public interface IPurchaseApplicationService
    {
        Task<double> CalculateTotalPrice(CreatePurchaseDTO purchaseDto);
        Task<double> CalculateDiscount(CreatePurchaseDTO purchaseDto);
        Task ApplyDiscount(CreatePurchaseDTO purchaseDto);
        Task<ReadPurchaseDTO> Add(CreatePurchaseDTO purchaseDto);

        Task<ReadPurchaseDTO> GetByIdAsync(int id);
        Task<IList<ReadPurchaseDTO>> ListAsync();

		Task<IList<ReadPurchaseDTO>> ListIncludingAsync();
        Task<ReadPurchaseDTO> GetByIdIncludingAsync(int id);
	}
}