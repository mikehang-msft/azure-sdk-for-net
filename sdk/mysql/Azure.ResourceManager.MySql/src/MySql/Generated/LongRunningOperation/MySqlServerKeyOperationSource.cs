// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MySql
{
    internal class MySqlServerKeyOperationSource : IOperationSource<MySqlServerKeyResource>
    {
        private readonly ArmClient _client;

        internal MySqlServerKeyOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlServerKeyResource IOperationSource<MySqlServerKeyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlServerKeyData.DeserializeMySqlServerKeyData(document.RootElement);
            return new MySqlServerKeyResource(_client, data);
        }

        async ValueTask<MySqlServerKeyResource> IOperationSource<MySqlServerKeyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlServerKeyData.DeserializeMySqlServerKeyData(document.RootElement);
            return new MySqlServerKeyResource(_client, data);
        }
    }
}
