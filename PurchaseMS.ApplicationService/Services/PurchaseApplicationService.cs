using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.DomainService.Interfaces;

namespace PurchaseMS.ApplicationService.Interfaces
{
    public class PurchaseApplicationService : IPurchaseApplicationService
    {
        private readonly IPurchaseDomainService _domainService;

        public PurchaseApplicationService(IPurchaseDomainService domainService)
        {
            _domainService = domainService;
        }

        public async Task<double> CalculateDiscount(CreatePurchaseDTO purchaseDto)
        {
            var totalPrice = await _domainService.CalculateDiscount(purchaseDto);
            return totalPrice;
        }

        public async Task<double> CalculateTotalPrice(CreatePurchaseDTO purchaseDto)
        {
            var totalPrice = await _domainService.CalculateTotalPrice(purchaseDto, purchaseDto.FreightValue);
            return totalPrice;
        }

        public async Task ApplyDiscount(CreatePurchaseDTO purchaseDto)
        {
            await _domainService.ApplyDiscount(purchaseDto);
        }


        public async Task<ReadPurchaseDTO> Add(CreatePurchaseDTO purchaseDto)
        {
            return await _domainService.AddAsync(purchaseDto);
        }


        public async Task<ReadPurchaseDTO> GetByIdAsync(int id)
        {
            return await _domainService.GetByIdAsync(id);
        }

        public async Task<ReadPurchaseDTO> GetByIdIncludingAsync(int id)
        {
            return await _domainService.GetByIdIncludingAsync(id);
        }


        public async Task<IList<ReadPurchaseDTO>> ListAsync()
        {
            return await _domainService.ListAsync();
        }

        public async Task<IList<ReadPurchaseDTO>> ListIncludingAsync()
        {
            return await _domainService.ListIncludingAsync();
        }
    }
}