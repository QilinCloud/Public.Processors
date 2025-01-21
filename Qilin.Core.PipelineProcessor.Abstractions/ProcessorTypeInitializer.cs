using System.Reflection;
using Qilin.Core.PipelineProcessor.Abstractions.Enums;

namespace Qilin.Core.PipelineProcessor.Abstractions;

public static class ProcessorTypeInitializer
{
    public static void InitializeProcessorTypes(Assembly assembly)
    {
        var pipelineProcessorTypes = assembly
            .GetTypes()
            .Where(t => t.IsSubclassOf(typeof(PipelineProcessorType)));

        foreach (var type in pipelineProcessorTypes)
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(type.TypeHandle);
        }
    }
}