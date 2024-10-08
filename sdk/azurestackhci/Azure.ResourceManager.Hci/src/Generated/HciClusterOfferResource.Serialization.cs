// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterOfferResource : IJsonModel<HciClusterOfferData>
    {
        void IJsonModel<HciClusterOfferData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterOfferData>)Data).Write(writer, options);

        HciClusterOfferData IJsonModel<HciClusterOfferData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterOfferData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<HciClusterOfferData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        HciClusterOfferData IPersistableModel<HciClusterOfferData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HciClusterOfferData>(data, options);

        string IPersistableModel<HciClusterOfferData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HciClusterOfferData>)Data).GetFormatFromOptions(options);
    }
}
