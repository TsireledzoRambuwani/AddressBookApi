

using Microsoft.AspNetCore.Http;

namespace Address_Book_Api.Application.Models
{
    public class FileResourceDto
    {
        public IFormFile File { get; set; }
        public string FileName { get; set; }
    }
}
