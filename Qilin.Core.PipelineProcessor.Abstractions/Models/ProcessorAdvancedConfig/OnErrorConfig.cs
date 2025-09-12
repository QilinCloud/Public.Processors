using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

public sealed class OnErrorConfig
{
    public bool IsContinue { get; set; }
    
    public OnErrorCustomStatus CustomStatus { get; set; } = OnErrorCustomStatus.Failed;

    public static readonly OnErrorConfig Default = new()
    {
        IsContinue = false,
        CustomStatus = OnErrorCustomStatus.Failed,
    };
}

[JsonConverter(typeof(StringEnumConverter))]
public enum OnErrorCustomStatus
{
    Failed = 1,
    Warning = 2,
    Ignored = 3,
}