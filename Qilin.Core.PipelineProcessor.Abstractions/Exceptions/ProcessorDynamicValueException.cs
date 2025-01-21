namespace Qilin.Core.PipelineProcessor.Abstractions.Exceptions;

public class ProcessorDynamicValueException : PipelineProcessorException
{
    public ProcessorDynamicValueException(string? message) : base(message)
    {
    }

    public ProcessorDynamicValueException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}