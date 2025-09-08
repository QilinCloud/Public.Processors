using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

namespace Qilin.Core.PipelineProcessor.Abstractions.Models;

public abstract class PipelineProcessorConfig
{
    [JsonConverter(typeof(StringEnumConverter))]
    public ContinueOnErrorBehavior ContinueOnErrorBehavior { get; set; } = ContinueOnErrorBehavior.Stop;
    
    [JsonConverter(typeof(StringEnumConverter))]
    public TrackingStatusOnErrorBehavior TrackingStatusOnErrorBehavior { get; set; } = TrackingStatusOnErrorBehavior.Failed;
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public TimeoutConfig? TimeoutConfig { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public RetryConfig? RetryConfig { get; set; }
    
    public uint ExecutionDelayInSeconds { get; set; }
    public string? ProcessorToGetFlowObjectContent { get; set; }
    
    [JsonIgnore]
    [BsonIgnore]
    public virtual HashSet<PipelineProcessorAdvancedConfig> EnabledAdvancedConfigs { get; protected set; } = [];
}