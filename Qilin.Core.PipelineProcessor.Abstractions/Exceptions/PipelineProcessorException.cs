namespace Qilin.Core.PipelineProcessor.Abstractions.Exceptions;

public class PipelineProcessorException : Exception
{
    public PipelineProcessorException(string? message) : base(message)
    {
    }

    public PipelineProcessorException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}