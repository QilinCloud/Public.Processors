using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

public class MergeTimeoutConfig
{
    public int TimeoutInMilliseconds { get; set; }
    public string[] RequiredProcessorInputIds { get; set; } = Array.Empty<string>();
    
    [JsonConverter(typeof(StringEnumConverter))]
    public MergeProcessorTimeoutPolicy MergeProcessorTimeoutPolicy { get; set; } =
        MergeProcessorTimeoutPolicy.WaitForAllInputProcessors;
}