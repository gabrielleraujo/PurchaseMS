using AutoMapper;
using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.Domain.Models.Discounts.Interfaces;
using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.DomainService.Mappers;
using PurchaseMS.Infrastructure.Data.Repository;

namespace PurchaseMS.DomainService.Interfaces
{
    public class PurchaseDomainService : IPurchaseDomainService
    {
        private readonly ICustomMapper _mapper;
        private readonly IChainOfDiscounts _chainOfDiscounts;
        private IPurchaseRepository<Purchase> _repository;

        public PurchaseDomainService(ICustomMapper mapper, IChainOfDiscounts chainOfDiscounts, IPurchaseRepository<Purchase> repository)
        {
            _mapper = mapper;
            _chainOfDiscounts = chainOfDiscounts;
            _repository = repository;
        }

        public async Task<double> CalculateDiscount(CreatePurchaseDTO purchaseDto)
        {
            var entity = _mapper.Map(purchaseDto);

            var totalPrice = entity.CalculateDiscont(_chainOfDiscounts);
            return totalPrice;
        }

        public async Task<double> CalculateTotalPrice(CreatePurchaseDTO purchaseDto,double otherValues)
        {
            var totalPrice = await CalculateDiscount(purchaseDto) + otherValues;
            return totalPrice;
        }

        public async Task ApplyDiscount(CreatePurchaseDTO purchaseDto)
        {
            var entity = _mapper.Map(purchaseDto);

            entity.ApplyDiscont(_chainOfDiscounts);
        }


        public async Task<ReadPurchaseDTO> AddAsync(CreatePurchaseDTO purchaseDto)
        {
            var entity = _mapper.Map(purchaseDto);

            entity.ApplyDiscont(_chainOfDiscounts);
            entity.AddFreight();
            entity.PaymentValidation();

            await _repository.AddAsync(entity);
            await _repository.Commit();

            return _mapper.Map(entity);
        }


        public async Task<ReadPurchaseDTO> GetByIdAsync(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            return _mapper.Map(result);
        }

        public async Task<ReadPurchaseDTO> GetByIdIncludingAsync(int id)
        {
            var result = await _repository.GetByIdIncludingAsync(id);
            return _mapper.Map(result);
        }


        public async Task<IList<ReadPurchaseDTO>> ListAsync()
        {
            var result = await _repository.ListAsync();
            return _mapper.Map(result);
        }

        public async Task<IList<ReadPurchaseDTO>> ListIncludingAsync()
        {
            var result = await _repository.ListIncludingAsync();
            return _mapper.Map(result);
        }
    }
}