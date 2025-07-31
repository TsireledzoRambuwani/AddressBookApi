

using Microsoft.AspNetCore.Http;

namespace Address_Book_Api.Domain.Models
{
    public class FileResource
    {
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
