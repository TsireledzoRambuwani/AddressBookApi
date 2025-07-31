
using Address_Book_Api.Application.Dtos;
using Address_Book_Api.Application.Models;

namespace Address_Book_Api.Application.Interfaces
{
    public interface IAddressBookRepository
    {
        Task<IEnumerable<AddressBookDto>> GetAllAsync();
        Task<AddressBookDto> GetByIdAsync(string id);
        Task<RepositoryResponse> RequestCVAsync(string id);
    }
}
