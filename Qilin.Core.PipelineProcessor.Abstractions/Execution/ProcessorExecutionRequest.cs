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
    public string PipelineExecutionId { get; init; } = null!;
    public string[] ObjectTransactionIds { get; init; } = [];
    public string CurrentProcessorExecutionId { get; init; } = null!;
    public string EntryProcessorId { get; set; } = null!;
    
    // Test mode only
    public Dictionary<string, Dictionary<string, string>> PinnedFlowObjectAttributes { get; init; } = new();
    public Dictionary<string, object?> PinnedFlowObjectContents { get; init; } = new();
}