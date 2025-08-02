

using System.Net;

namespace Address_Book_Api.Application.Models
{
    public class ApiResponse<T>(bool success,
        string? message = null,
        T data = default, 
        List<string>? errors = null,
        HttpStatusCode? code = null)
    {
        public bool Success { get; set; } = success;
        public string? Message { get; set; } = message;
        public T Data { get; set; } = data;
        public HttpStatusCode? Code { get; set; } = code;
        public List<string>? Errors { get; set; } = errors;

        public static ApiResponse<T> CreateSuccessResponse(T data) 
         => new(true, null, data, null, HttpStatusCode.OK);
        

        public static ApiResponse<T> CreateErrorResponse(string message,
            List<string>? errors = null,
            HttpStatusCode? code = HttpStatusCode.BadRequest)
         => new(false, message, default, errors, code);
        
    }
}
