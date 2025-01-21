namespace Qilin.Core.PipelineProcessor.Abstractions.Models.ProcessorAdvancedConfig;

public enum MergeProcessorTimeoutPolicy
{
    WaitForAllInputProcessors = 1,
    WaitForAllRequiredInputProcessors = 2,
    WaitForAnyInputProcessor = 3
}