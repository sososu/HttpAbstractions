// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Authentication
{
    /// <summary>
    /// Holds error information from the authentication.
    /// </summary>
    public class AuthenticationError
    {
        public AuthenticationError(Exception failure)
        {
            Failure = failure ?? throw new ArgumentNullException(nameof(failure));
        }

        public AuthenticationError(Exception failure, AuthenticationProperties properties)
            : this(failure)
        {
            Properties = properties;
        }

        /// <summary>
        /// Holds failure information from the authentication.
        /// </summary>
        public Exception Failure { get; }

        /// <summary>
        /// Additional state values for the authentication session.
        /// </summary>
        public AuthenticationProperties Properties { get; }
    }
}
