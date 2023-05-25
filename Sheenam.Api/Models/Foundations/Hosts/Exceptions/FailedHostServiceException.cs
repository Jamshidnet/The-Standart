﻿//===================================================
// Copyright (c)  coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Pease
//===================================================

using System;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Hosts.Exceptions
{
    public class FailedHostServiceException : Xeption
    {
        public FailedHostServiceException(Exception innerException)
            : base(message: "Failed host service occurred, please contact support",
                  innerException)
        { }
    }
}
