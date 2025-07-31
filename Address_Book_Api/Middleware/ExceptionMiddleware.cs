

using Address_Book_Api.Application.Models;
using Address_Book_Api.Exceptions;
using System.Net;
using System.Text.Json;

namespace Address_Book_Api.Middleware
{
    public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        public readonly RequestDelegate _next = next;
        public readonly ILogger<ExceptionMiddleware> _logger = logger;

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                HttpStatusCode statusCode;
                string message;
                List<string>? errors= null;

                switch (error)
                {
                    case ApiException apiex:
                        statusCode = HttpStatusCode.BadRequest;
                        message = apiex.Message;
                        break;

                    case ValidationExecption validationException:
                        statusCode = HttpStatusCode.BadRequest;
                        message = validationException.Message;
                        errors = validationException.Errors;
                        break;

                    case UnauthorizedAccessException ex:
                        statusCode = HttpStatusCode.Unauthorized;
                        message = ex.Message;
                        break;

                    case KeyNotFoundException knfex:
                        statusCode = HttpStatusCode.NotFound;
                        message = knfex.Message;
                        break;

                    default:
                        statusCode = HttpStatusCode.InternalServerError;
                        message ="";
                        break;
                }

                _logger.LogError(message);

                response.StatusCode = (int)statusCode;

                 var result = ApiResponse<string>.CreateErrorResponse(message, errors, statusCode);

                var json   = JsonSerializer.Serialize(result);

                await response.WriteAsync(json);
               
            }
        }
    }
}
