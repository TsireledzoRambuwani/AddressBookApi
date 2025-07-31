

using System.Net;

namespace Address_Book_Api.Application.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T Data { get; set; }
        public HttpStatusCode? Code { get; set; }
        public List<string>? Errors { get; set; }

        public ApiResponse()
        {
                
        }

        public ApiResponse(bool success, string message =null, T data =default, List<string>? errors =null , HttpStatusCode? code = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Errors = errors;
            Code = code;

        }

        public static ApiResponse<T> CreateSuccessResponse(T data) 
         => new ApiResponse<T>(true, null, data, null, HttpStatusCode.OK);
        

        public static ApiResponse<T> CreateErrorResponse(string message, List<string>? errors = null, HttpStatusCode? code = HttpStatusCode.BadRequest)
         => new ApiResponse<T>(false, message, default, errors, code);
        
    }
}
