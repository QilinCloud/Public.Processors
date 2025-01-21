using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Config;

public class ConsoleWriterProcessorConfig : PipelineProcessorConfig
{
    public ProcessorDynamicValue Message { get; set; }
}