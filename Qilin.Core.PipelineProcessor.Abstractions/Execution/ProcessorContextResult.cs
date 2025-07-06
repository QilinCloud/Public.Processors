namespace Qilin.Core.PipelineProcessor.Abstractions.Execution;

public class ProcessorContextResult
{
    public ProcessorExecutedStatus Status { get; init; }
    public Dictionary<string, object> AdditionalInformation { get; set; } = new();
    public Exception? Exception { get; init; }
    public Dictionary<string, object?> FlowObjectAttributes { get; init; } = new();
    public object? FlowObjectContent { get; set; }
}

public enum ProcessorExecutedStatus
{
    Passed = 1,
    Exception = 2,
    Stopped = 3,
    TimedOut = 4
}