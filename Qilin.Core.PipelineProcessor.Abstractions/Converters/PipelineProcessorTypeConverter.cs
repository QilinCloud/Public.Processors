using Newtonsoft.Json;
using Qilin.Core.PipelineProcessor.Abstractions.Enums;

namespace Qilin.Core.PipelineProcessor.Abstractions.Converters;


public class PipelineProcessorTypeConverter : JsonConverter<PipelineProcessorType>
{
    public override PipelineProcessorType ReadJson(JsonReader reader, Type objectType, PipelineProcessorType? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var value = reader.Value.ToString();
        if (string.IsNullOrEmpty(value))
            return null;

        // Try to parse the value and return the corresponding ProcessorType instance
        if (PipelineProcessorType.TryParse(value, out var processor))
        {
            return processor.Item1;
        }

        throw new JsonSerializationException($"Unknown PipelineProcessorType: {value}");
    }

    public override void WriteJson(JsonWriter writer, PipelineProcessorType value, JsonSerializer serializer)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        writer.WriteValue(value.Name);
    }
}
