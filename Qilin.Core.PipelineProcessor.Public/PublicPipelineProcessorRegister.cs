using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Qilin.Core.PipelineProcessor.Abstractions;
using Qilin.Core.PipelineProcessor.Abstractions.Execution;
using Qilin.Core.PipelineProcessor.Public.ConsoleWriterProcessor.Executions;

namespace Qilin.Core.PipelineProcessor.Public;

public static class PublicPipelineProcessorRegister
{
    public static void AddPublicPipelineProcessor(this IServiceCollection services)
    {
        ProcessorTypeInitializer.InitializeProcessorTypes(Assembly.GetExecutingAssembly());
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public static void RegisterPublicProcessorStrategies(this IServiceCollection services)
    {
        services.AddKeyedScoped<IProcessorStrategy, ConsoleWriterProcessorExecuteStrategy>(PublicPipelineProcessorType.ConsoleWriterProcessorType);
    }
}