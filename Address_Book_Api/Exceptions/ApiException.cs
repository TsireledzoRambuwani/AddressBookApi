﻿using System.Globalization;

namespace Address_Book_Api.Exceptions
{
    public class ApiException:Exception
    {
        public ApiException(): base(){}

        public ApiException(string message):base(message){}
        public ApiException(string? message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
