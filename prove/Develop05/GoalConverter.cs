using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();
            var goalJson = root.GetRawText();

            return type switch
            {
                nameof(SimpleGoal) => JsonSerializer.Deserialize<SimpleGoal>(goalJson, options),
                nameof(EternalGoal) => JsonSerializer.Deserialize<EternalGoal>(goalJson, options),
                nameof(ChecklistGoal) => JsonSerializer.Deserialize<ChecklistGoal>(goalJson, options),
                _ => throw new NotSupportedException($"Goal type '{type}' is not supported")
            };
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name);
        writer.WritePropertyName("Data");
        JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        writer.WriteEndObject();
    }
}
