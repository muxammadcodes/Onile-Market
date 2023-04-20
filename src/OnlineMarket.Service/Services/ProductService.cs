using AutoMapper;
using OnlineMarket.DataAccess.IRepositories;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Service.Commons.Exceptions;
using OnlineMarket.Service.DTOs;
using OnlineMarket.Service.Interfaces;

namespace OnlineMarket.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper mapper;
        public ProductService(IMapper mapper,IGenericRepository<Product> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<ProductForResultDto> AddAsync(ProductCreationDto dto)
        {
            var product = await this.repository.GetAsync(pr => pr.Name == dto.Name);
            if (product is not null)
            {
                var mapped = this.mapper.Map<ProductForResultDto>(dto);
                await this.UpdateAsync(mapped);
            }

            var mappedProduct = this.mapper.Map<Product>(dto);
            var result = await this.repository.InsertAsync(mappedProduct);
            await this.repository.SaveAsync();

            return this.mapper.Map<ProductForResultDto>(result);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await this.repository.GetAsync(p => p.Id == id);
            if (product is  null)
                throw new CustomException(404, "Product is not found for given id");

            var res = await this.repository.DeleteAsync(p => p.Id == id);
            await this.repository.SaveAsync();

            return res;
        }

        public async Task<IEnumerable<ProductForResultDto>> RetrievAllAsync()
        {
            var products = this.repository.GetAllAsync();
            if (products is  null)
                throw new CustomException(404, "Products are not found ");

            return this.mapper.Map<IEnumerable<ProductForResultDto>>(products);

        }

        public async Task<ProductForResultDto> RetrievByIdAsync(int id)
        {
            var product = await this.repository.GetAsync(p => p.Id == id);
            if (product is null)
                throw new CustomException(404, "Product is not found for given id");

            return this.mapper.Map<ProductForResultDto>(product);
        }

        public async Task<ProductForResultDto> UpdateAsync(ProductForResultDto dto)
        {
            var product = await this.repository.GetAsync(p => p.Id == dto.Id);
            if (product is null)
                throw new CustomException(404, "Product is not found for given id");

            var mapped = this.mapper.Map(dto, product);
            await this.repository.SaveAsync();

            return this.mapper.Map<ProductForResultDto>(mapped);
        }
    }
}
