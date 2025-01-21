namespace Qilin.Core.PipelineProcessor.Abstractions.Execution;

public interface IProcessorStrategy
{
    Task<ProcessorContextResult> ExecuteProcessorAsync(ProcessorExecutionRequest processorExecutionRequest,
        CancellationToken cancellationToken = default);
}