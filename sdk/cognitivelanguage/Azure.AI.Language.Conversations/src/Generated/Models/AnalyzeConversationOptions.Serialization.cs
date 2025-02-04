// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class AnalyzeConversationOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("query");
            writer.WriteStringValue(Query);
            if (Optional.IsDefined(DirectTarget))
            {
                writer.WritePropertyName("directTarget");
                writer.WriteStringValue(DirectTarget);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Verbose))
            {
                writer.WritePropertyName("verbose");
                writer.WriteBooleanValue(Verbose.Value);
            }
            if (Optional.IsDefined(IsLoggingEnabled))
            {
                writer.WritePropertyName("isLoggingEnabled");
                writer.WriteBooleanValue(IsLoggingEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
