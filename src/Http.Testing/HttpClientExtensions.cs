using System;
using System.Net.Http;

namespace PingDong.Http.Testing
{
    public static class HttpClientExtensions
    {
        public static HttpClient AddRequestId(this HttpClient client, string requestId = null, string key = "x-request-id")
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            requestId = string.IsNullOrWhiteSpace(requestId) ? Guid.NewGuid().ToString() : requestId;

            client.DefaultRequestHeaders.Add(key, requestId);

            return client;
        }

        public static HttpClient AddCorrelationId(this HttpClient client, string correlationId = null, string key = "x-correlation-id")
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            correlationId = string.IsNullOrWhiteSpace(correlationId) ? Guid.NewGuid().ToString() : correlationId;

            client.DefaultRequestHeaders.Add(key, correlationId);

            return client;
        }

        public static HttpClient AddTenantId(this HttpClient client, string tenantId = null, string key = "x-tenant-id")
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            tenantId = string.IsNullOrWhiteSpace(tenantId) ? Guid.NewGuid().ToString() : tenantId;

            client.DefaultRequestHeaders.Add(key, tenantId);

            return client;
        }
    }
}
