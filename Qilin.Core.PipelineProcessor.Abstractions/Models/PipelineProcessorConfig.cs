using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

namespace Qilin.Core.PipelineProcessor.Abstractions.Models;

public abstract class PipelineProcessorConfig
{
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public TimeoutConfig? TimeoutConfig { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public RetryConfig? RetryConfig { get; set; }
    
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public OnErrorConfig? OnErrorConfig { get; set; }
    
    public uint ExecutionDelayInSeconds { get; set; }
    public string? ProcessorToGetFlowObjectContent { get; set; }
    
    [JsonIgnore]
    [BsonIgnore]
    public virtual HashSet<PipelineProcessorAdvancedConfig> EnabledAdvancedConfigs { get; protected set; } = [];
}