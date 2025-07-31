namespace Qilin.Core.PipelineProcessor.Abstractions.Execution;

public class ProcessorContextResult
{
    public ProcessorExecutedStatus Status { get; init; }
    public Dictionary<string, object> AdditionalInformation { get; set; } = new();
    public Exception? Exception { get; init; }
    public Dictionary<string, string> FlowObjectAttributes { get; init; } = new();
    public object? FlowObjectContent { get; set; }
}

public enum ProcessorExecutedStatus
{
    Passed = 1,
    Exception = 2,
    Stopped = 3,
    TimedOut = 4,
    // When marking a processor as InProgress, its result will not be written to Pipeline Execution Context, and next processors will not be executed.
    // It will need somewhere else to call back to write the result, and then continue the pipeline execution.
    // For example, this can be used for triggering sub pipeline and wait for result, where the sub-pipeline will call back to write the result.
    InProgress = 5, 
}