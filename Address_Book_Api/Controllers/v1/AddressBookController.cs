using Address_Book_Api.Application.Dtos;
using Address_Book_Api.Application.Interfaces;
using Address_Book_Api.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Address_Book_Api.Controllers.v1
{
    public class AddressBookController(
        IAddressBookRepository addressBookRepository,
        ILogger<AddressBookController> logger): BaseController()
    {
        private readonly IAddressBookRepository _addressBookRepository = addressBookRepository;
        private readonly ILogger<AddressBookController> _logger = logger;


        /// <summary>
        ///  Gets List of Address Books
        /// </summary>
        /// <returns> List of Address Books</returns>
        [HttpGet("GetAll")]
        public async Task<IActionResult> Index()
        {
            try
            {
                var addressBooks = await _addressBookRepository.GetAllAsync();

                return Ok(ApiResponse<IEnumerable<AddressBookDto>>
                        .CreateSuccessResponse(addressBooks));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return Ok(ApiResponse<string>
                    .CreateErrorResponse(ex.Message, null, System.Net.HttpStatusCode.InternalServerError));

            }
        }



        /// <summary>
        ///  Sends Email to profile email to request CV
        /// </summary>
        /// <param name="id">Address Book Id</param>
       

        [HttpGet("RequestCV{id}")]
        public async Task<IActionResult> RequestCV(string id)
        {
            try
            {
                var response = await _addressBookRepository.RequestCVAsync(id);

                return Ok(ApiResponse<RepositoryResponse>
                       .CreateSuccessResponse(response));
            }
            catch (Exception ex)
            {

                _logger.LogError(ex.Message);
                return Ok(ApiResponse<string>
                .CreateErrorResponse(ex.Message, null, System.Net.HttpStatusCode.InternalServerError));

            }
        }
    }
}
