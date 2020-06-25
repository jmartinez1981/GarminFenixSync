﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyGarmin.Dashboard.Connectivity.GarminClient.Data.Converters
{
    internal class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}
