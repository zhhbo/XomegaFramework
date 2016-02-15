﻿// Copyright (c) 2010-2013 Xomega.Net. All rights reserved.

using System.Collections;

namespace Xomega.Framework
{
    /// <summary>
    /// An interface for objects that support validation.
    /// </summary>
    public interface IValidatable
    {
        /// <summary>
        /// Validates the data object and all its properties and child objects recursively.
        /// </summary>
        /// <param name="force">True to validate regardless of
        /// whether or not it has been already validated.</param>
        void Validate(bool force);
    }
}
