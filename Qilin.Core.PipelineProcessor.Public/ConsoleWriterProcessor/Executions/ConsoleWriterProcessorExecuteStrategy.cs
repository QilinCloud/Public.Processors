using Qilin.Core.PipelineProcessor.Abstractions.Execution;
using Qilin.Core.PipelineProcessor.Abstractions.Extensions;
using Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Config;
using Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Exceptions;

namespace Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Executions;

public class ConsoleWriterProcessorExecuteStrategy : IProcessorStrategy
{
    public Task<ProcessorContextResult> ExecuteProcessorAsync(ProcessorExecutionRequest processorExecutionRequest,
        CancellationToken cancellationToken = default)
    {
        // Handle logic of the processor here
        if (processorExecutionRequest.PipelineProcessorConfig is not ConsoleWriterProcessorConfig config)
        {
            throw new ConsoleWriterProcessorException("Config not found");
        }
        
        var message = config.Message.GetValue<string>(processorExecutionRequest);
        
        Console.WriteLine(message);
        
        // The result should be returned as ProcessorContextResult
        return Task.FromResult(new ProcessorContextResult
        {
            Status = ProcessorExecutedStatus.Passed,
            FlowObjectContent = processorExecutionRequest.FlowObjectContent
        });
    }
}