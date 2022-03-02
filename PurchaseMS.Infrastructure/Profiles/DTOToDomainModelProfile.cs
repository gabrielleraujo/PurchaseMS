using AutoMapper;
using PurchaseMS.CrossCutting.Dtos;
using PurchaseMS.Domain.Models.Entities;
using PurchaseMS.Domain.Models.States;
using PurchaseMS.Domain.Models.ValueObjects;

namespace PurchaseMS.Infrastructure.Profiles
{
    public class DTOToDomainModelProfile : Profile
    {
        public DTOToDomainModelProfile()
        {
            CreateMap<CreateBuyerDTO, Buyer>()
                .ConstructUsing(x => new Buyer(x.Id, x.Name, x.Surname, x.Username, x.Email));

            CreateMap<CreateAddressDTO, Address>()
                .ConstructUsing( x => new Address(x.ZipCode, x.Street, x.Number, x.Complement, x.Neighborhood, x.City, x.UF));

            CreateMap<InputCategoryDTO, Category>()
                .ConstructUsing(x => new Category(x.CategoryText));

            CreateMap<InputColorDTO, Color>()
                .ConstructUsing(x => new Color(x.ColorText));

            CreateMap<InputSizeDTO, Size>()
                .ConstructUsing(x => new Size(x.SizeText));

            CreateMap<InputProductDTO, Product>()
                .ConstructUsing(x => new Product(x.Id, x.Name, x.Price, x.Description,
                        new Category(x.Category.CategoryText),
                        new Color(x.Color.ColorText),
                        new Size(x.Size.SizeText)));




            CreateMap<CreatePurchaseItemDTO, PurchaseItem>()
                .ConstructUsing(x => new PurchaseItem(
                    x.Id, x.Product.Id,
                    new Product(x.Product.Id, x.Product.Name, x.Product.Price, x.Product.Description,
                        new Category(x.Product.Category.CategoryText),
                        new Color(x.Product.Color.ColorText),
                        new Size(x.Product.Size.SizeText)), x.UnitPrice, x.Quantity));




            CreateMap<CreatePurchaseDTO, Purchase>()
                .ConstructUsing(x => new Purchase(
                    new Buyer(x.Buyer.Id, x.Buyer.Name, x.Buyer.Surname, x.Buyer.Username, x.Buyer.Email), x.Buyer.Id,
                    new Address(x.Address.ZipCode, x.Address.Street, x.Address.Number, x.Address.Complement, x.Address.Neighborhood, x.Address.City, x.Address.UF),
                    x.Date, x.Price, x.HasSummary, x.FreightValue, new InitialState()))

                .AfterMap((dest, src) =>
                {
                    foreach (var x in src.PurchaseItems)
                    {
                        CreateMap<CreatePurchaseItemDTO, PurchaseItem>()
                        .ConstructUsing(x => new PurchaseItem(
                            x.Id, x.Product.Id,
                            new Product(x.Product.Id, x.Product.Name, x.Product.Price, x.Product.Description,
                                new Category(x.Product.Category.CategoryText),
                                new Color(x.Product.Color.ColorText),
                                new Size(x.Product.Size.SizeText)), x.UnitPrice, x.Quantity));
                    }
                });
        }
    }
}