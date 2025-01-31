using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.Wrapping
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }

        // Default constructor
        public ApiResponse()
        {
            Success = false; // Default to false
            ErrorMessage = null;
            Message = null;
        }

        // Constructor for successful responses
        public ApiResponse(T data, string message = null)
        {
            Success = true;
            Data = data;
            Message = message;
            ErrorMessage = null;
        }

        // Constructor for error responses
        public ApiResponse(string errorMessage, string message = null)
        {
            Success = false;
            ErrorMessage = errorMessage;
            Message = message;
            Data = default; // Set Data to default value for type T
        }
    }
}
