using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GismeteoTest.Shared.ResponseModel
{
    /// <summary>
    /// модель содержащая ошибку выполнения API
    /// </summary>
    public class ErrorResponse
    {
        public int ErrorCode { get; set; } 

        public string Message { get; set; }
    }
}
