using System;
using System.Net.Http;
using System.Threading;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace FinancialModelingPrep.Core.Http;

internal sealed class RateLimitedHandler : DelegatingHandler
{
    private readonly RateLimiter _rateLimiter;
    private readonly TimeSpan _maxJitter;

    internal RateLimitedHandler(RateLimiter rateLimiter, TimeSpan maxJitter = default)
    {
        _rateLimiter = rateLimiter;
        _maxJitter = maxJitter;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
    {
        using var lease = await _rateLimiter.AcquireAsync(permitCount: 1, cancellationToken);

        if (_maxJitter > TimeSpan.Zero)
        {
            var jitterMs = Random.Shared.NextDouble() * _maxJitter.TotalMilliseconds;
            await Task.Delay(TimeSpan.FromMilliseconds(jitterMs), cancellationToken);
        }

        return await base.SendAsync(request, cancellationToken);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            _rateLimiter.Dispose();
        base.Dispose(disposing);
    }
}
