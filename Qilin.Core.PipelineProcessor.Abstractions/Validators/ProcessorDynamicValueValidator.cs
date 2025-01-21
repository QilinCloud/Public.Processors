using FluentValidation;
using Qilin.Core.PipelineProcessor.Abstractions.Enums;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Validators;

public class ProcessorDynamicValueValidator : AbstractValidator<ProcessorDynamicValue>
{
    public ProcessorDynamicValueValidator()
    {
        RuleFor(x => x)
            .Must(x => x.Raw is not null || x.Path is not null)
            .WithErrorCode(PipelineProcessorErrorCode.ValueIsRequired.ToString());

        RuleFor(x => x)
            .Must(x => !(x.Raw is not null && x.Path is not null))
            .WithErrorCode(PipelineProcessorErrorCode.DynamicValueCanNotObtainMultipleValues.ToString());
    }    
}