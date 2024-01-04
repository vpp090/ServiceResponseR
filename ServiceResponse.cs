using System;
namespace ServiceResponse
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public Exception Error { get; set; }

        public ServiceResponse(T data)
        {
            Data = data;
        }

        public ServiceResponse(Exception error)
        {
            Error = error;
        }
    }
}
