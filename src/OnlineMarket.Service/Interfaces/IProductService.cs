using OnlineMarket.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.Service.Interfaces
{
    public interface IProductService
    {
        public Task<ProductForResultDto> AddAsync(ProductCreationDto dto);
        public Task<ProductForResultDto> UpdateAsync(ProductForResultDto dto);
        public Task<bool> DeleteAsync(int id);
        public Task<ProductForResultDto> RetrievAsync(int id);
        public Task<IEnumerable<ProductForResultDto>> GetAllAsync();
    }
}
