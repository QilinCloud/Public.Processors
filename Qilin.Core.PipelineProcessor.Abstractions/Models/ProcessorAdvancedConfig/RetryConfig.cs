namespace Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

public class RetryConfig
{
    public short MaximumRetries { get; set; }
    public int RetryAfterInSeconds { get; set; }
}