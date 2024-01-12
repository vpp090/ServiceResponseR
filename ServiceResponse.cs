using System;
namespace ServiceResponseR
{
    public class ServiceResponse<T>
    {
        public T Data { get; private set; }
        public string ErrorMessage { get; private set; }
        public ErrorDetails ErrorDetails { get; private set; }
        public string ErrorCode { get; private set; }
        public bool IsSuccess { get; private set; }

        public ServiceResponse(T data)
        {
            Data = data ?? throw new ArgumentException(nameof(data));
        }

        public ServiceResponse(string errorCode, string errorMessage, ErrorDetails errorDetails = null)
        {
            ErrorCode = errorCode ?? throw new ArgumentException(nameof(errorCode));
            ErrorMessage = errorMessage ?? throw new ArgumentException(nameof(errorMessage));
            ErrorDetails = errorDetails;
        }
    }

    public class ErrorDetails
    {
        public string DeveloperMessage { get; set; }
        public string AdditionalContext { get; set; }
    }
}
