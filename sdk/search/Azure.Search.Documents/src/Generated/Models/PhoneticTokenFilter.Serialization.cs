// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class PhoneticTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Encoder))
            {
                writer.WritePropertyName("encoder");
                writer.WriteStringValue(Encoder.Value.ToSerialString());
            }
            if (Optional.IsDefined(ReplaceOriginalTokens))
            {
                writer.WritePropertyName("replace");
                writer.WriteBooleanValue(ReplaceOriginalTokens.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static PhoneticTokenFilter DeserializePhoneticTokenFilter(JsonElement element)
        {
            Optional<PhoneticEncoder> encoder = default;
            Optional<bool> replace = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encoder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encoder = property.Value.GetString().ToPhoneticEncoder();
                    continue;
                }
                if (property.NameEquals("replace"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replace = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneticTokenFilter(odataType, name, Optional.ToNullable(encoder), Optional.ToNullable(replace));
        }
    }
}
