﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.Core
{
    internal class ExponentialDelayStrategy : DelayStrategy
    {
        private readonly TimeSpan _delay;

        public ExponentialDelayStrategy(TimeSpan? delay = default, TimeSpan? maxDelay = default)
            : base(maxDelay)
        {
            _delay = delay ?? RetryOptions.DefaultInitialDelay;
        }

        protected override TimeSpan GetNextDelayCore(Response? response, int retryNumber) =>
            TimeSpan.FromMilliseconds((1 << (retryNumber - 1)) * _delay.TotalMilliseconds);
    }
}
