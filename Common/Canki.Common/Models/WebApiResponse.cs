﻿namespace Canki.Common.Models
{
    public class WebApiResponse<T>
    {
        public WebApiResponse()
        {

        }

        public WebApiResponse(bool isSuccess, string resultMessage)
        {
            IsSuccess = isSuccess;
            ResultMessage = resultMessage;
        }

        public WebApiResponse(bool isSuccess, string resultMessage, T resultData)
            : this(isSuccess, resultMessage)
        {
            ResultData = resultData;
        }

        public bool IsSuccess { get; set; }
        public string ResultMessage { get; set; }
        public T ResultData { get; set; }
    }
}
