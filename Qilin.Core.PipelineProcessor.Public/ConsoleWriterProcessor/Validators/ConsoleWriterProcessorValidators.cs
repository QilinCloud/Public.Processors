using FluentValidation;
using Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Config;

namespace Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Validators;

public class ConsoleWriterProcessorValidators : AbstractValidator<ConsoleWriterProcessorConfig>
{
    public ConsoleWriterProcessorValidators()
    {
        RuleFor(x => x.Message)
            .NotEmpty();
    }
}