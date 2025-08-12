using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Execution;

public class ProcessorExecutionRequest
{
    public PipelineProcessorConfig PipelineProcessorConfig { get; init; } = null!;
    public PipelineProcessorType PipelineProcessorType { get; init; }
    public string SubscriptionId { get; init; } = null!;
    public string PipelineId { get; init; } = null!;
    public string ProcessorId { get; init; } = null!;
    public string[] ParentProcessorIds { get; init; } = [];
    public Dictionary<string, Dictionary<string, string>> FlowObjectAttributes { get; init; }
    public Dictionary<string, object?> FlowObjectContents { get; init; }
    public string TrackingTransactionId { get; init; } = null!;
    public string CurrentTransactionBlockId { get; init; } = null!;
    public List<string> TrackingTransactionParentBlockIds { get; init; } = [];
    public string? SourceChannelEntryProcessorId { get; set; }  
}