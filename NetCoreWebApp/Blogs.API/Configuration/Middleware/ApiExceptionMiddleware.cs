using Blogs.API.Configuration.Models.v1;
using Domain.Shared.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blogs.API.Configuration.Middleware
{
    public class ApiExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public ApiExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            int statusCode;
            string category, message;

            if (exception is BaseException domainException)
            {
                //statusCode = (int)GetDomainErrorStatusCode(domainException);
                category = domainException.Category;
                message = domainException.Message;
            }
            else
            {
                statusCode = (int)HttpStatusCode.InternalServerError;
                category = "System Error";
                message = "An internal system error occurred";
            }

            context.Response.ContentType = "application/json";

            var error = new ErrorResponse
            {
                Error = new ErrorModel
                {
                    Category = category,
                    Message = message
                }
            };

            var jsonErrorResult = JsonSerializer.Serialize(error, _jsonOptions);

            await context.Response.WriteAsync(jsonErrorResult);
        }
    }
}
