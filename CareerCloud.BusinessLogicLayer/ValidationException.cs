﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ValidationException : Exception
    {
        public readonly int Code;

        public ValidationException(int code, string Message) : base(Message)
        {
            Code = code;

        }
    }
}
