using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Execution;

public class ProcessorExecutionRequest
{
    public PipelineProcessorConfig PipelineProcessorConfig { get; init; } = null!;
    public PipelineProcessorType PipelineProcessorType { get; init; }
    public string SubscriptionId { get; init; } = null!;
    public Dictionary<string, Dictionary<string, string>>? FlowObjectAttributes { get; init; }
    [Obsolete("Use FlowObjectContents instead", false)]
    public object? FlowObjectContent { get; set; }
    //TODO: Because of merge processor need multiple input processor, create this field. Need to remove FlowObjectContent field and change strategy of processors
    public Dictionary<string, object?> FlowObjectContents { get; init; }
}