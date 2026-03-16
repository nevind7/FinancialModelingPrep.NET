using System;
using System.Threading;
using System.Threading.Tasks;
using Bert.RateLimiters;
using FinancialModelingPrep.Abstractions.Http;

namespace FinancialModelingPrep.Core.Http
{
    public class RequestRateLimiter : IRequestRateLimiter
    {
        private readonly SemaphoreSlim threadsLimiter;
        private readonly RollingWindowThrottler maxApiCallsPerMinuteThrottler;
        private readonly RollingWindowThrottler maxRequestsPerSecondThrottler;

        public RequestRateLimiter(FinancialModelingPrepOptions options)
        {
            threadsLimiter = new SemaphoreSlim(options.MaxRequestPerSecond, options.MaxRequestPerSecond);
            maxApiCallsPerMinuteThrottler = new RollingWindowThrottler(options.MaxAPICallsPerMinute, TimeSpan.FromMinutes(1));
            maxRequestsPerSecondThrottler = new RollingWindowThrottler(options.MaxRequestPerSecond, TimeSpan.FromSeconds(1));
        }

        public async Task<(bool wasThrottled, TimeSpan totalDelay)> ThrottleAsync()
        {
            var totalDelay = TimeSpan.Zero;
            var wasThrottled = false;

            await threadsLimiter.WaitAsync();

            while (maxRequestsPerSecondThrottler.ShouldThrottle(out var waitTime))
            {
                wasThrottled = true;
                totalDelay = totalDelay.Add(TimeSpan.FromMilliseconds(waitTime));
            }

            while (maxApiCallsPerMinuteThrottler.ShouldThrottle(out var waitTime))
            {
                wasThrottled = true;
                totalDelay = totalDelay.Add(TimeSpan.FromMilliseconds(waitTime));

                await Task.Delay((int)waitTime);
            }

            return (wasThrottled, totalDelay);
        }

        public void ReleaseThrottle() => threadsLimiter.Release();
    }
}
