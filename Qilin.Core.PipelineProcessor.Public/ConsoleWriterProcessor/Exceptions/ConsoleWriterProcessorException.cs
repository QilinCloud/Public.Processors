using Qilin.Core.PipelineProcessor.Abstractions.Exceptions;

namespace Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Exceptions;

public class ConsoleWriterProcessorException : PipelineProcessorException
{
    public ConsoleWriterProcessorException(string? message) : base(message)
    {
    }

    public ConsoleWriterProcessorException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}