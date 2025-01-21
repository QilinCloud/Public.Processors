using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Config;

namespace Qilin.Core.PipelineProcessor.Public;

public class PublicPipelineProcessorType : PipelineProcessorType
{
    public static readonly PublicPipelineProcessorType ConsoleWriterProcessorType = 
        new("ConsoleWriter", typeof(ConsoleWriterProcessorConfig));
    
    public PublicPipelineProcessorType(string name, Type configType) : base(name, configType)
    {
    }
}