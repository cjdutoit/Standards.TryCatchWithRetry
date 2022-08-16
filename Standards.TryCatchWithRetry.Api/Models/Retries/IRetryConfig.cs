// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace Standards.TryCatchWithRetry.Api.Models.Retries
{
    public interface IRetryConfig
    {
        public int RetriesAllowed { get; set; }
        public TimeSpan DelayBetweenRetries { get; set; }
    }
}
