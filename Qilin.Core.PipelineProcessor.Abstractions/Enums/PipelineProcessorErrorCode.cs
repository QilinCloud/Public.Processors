using System.ComponentModel;

namespace Qilin.Core.PipelineProcessor.Abstractions.Enums;

public enum PipelineProcessorErrorCode
{
    [Description("Value is required for this operator/action")]
    ValueIsRequired = 1,
    
    [Description("Dynamic value can not obtain multiple values")]
    DynamicValueCanNotObtainMultipleValues = 10104, 
}