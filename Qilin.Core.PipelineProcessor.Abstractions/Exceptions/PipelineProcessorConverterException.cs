namespace Qilin.Core.PipelineProcessor.Abstractions.Exceptions;

public class PipelineProcessorConverterException : PipelineProcessorException
{
    public PipelineProcessorConverterException(string? message) : base(message)
    {
    }

    public PipelineProcessorConverterException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}