namespace Qilin.Core.PipelineProcessor.Abstractions.Models;

public class ProcessorDynamicValue
{
    /// <summary>
    /// The path for value for filtering
    /// </summary>
    /// <example>
    /// $.price
    /// </example>
    public string? Path { get; set; }

    /// <summary>
    /// The referred value for filtering
    /// </summary>
    /// <example>
    /// 123
    /// </example>
    public object? Raw { get; set; }
}