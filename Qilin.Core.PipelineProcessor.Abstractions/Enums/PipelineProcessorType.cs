using Newtonsoft.Json;
using Qilin.Core.PipelineProcessor.Abstractions.Converters;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Enums;

[JsonConverter(typeof(PipelineProcessorTypeConverter))]
public abstract class PipelineProcessorType
{
    public string Name { get; }

    private static readonly Dictionary<string, (PipelineProcessorType, Type)> Instances = new();

    private const string QilinProcessorTypePrefix = "Qilin";
    private const string PublicProcessorTypePrefix = "Public";

    protected PipelineProcessorType(string name, Type configType)
    {
        if (!configType.IsSubclassOf(typeof(PipelineProcessorConfig)))
        {
            throw new ArgumentException("Config type must be PipelineProcessorConfig", nameof(configType));
        }
        
        var type = GetType();
        name = GetFullNameWithType(name);
        if (Instances.ContainsKey(name))
        {
            throw new InvalidOperationException(
                $"PipelineProcessorType already exists for type {type.Name}");
        }

        Name = name;
        Instances.Add(Name, (this, configType));
    }
    
    public static bool TryParse(string name, out (PipelineProcessorType, Type) result)
    {
        return Instances.TryGetValue(name, out result);
    }
    
    public override string ToString() => Name;
    
    private string GetFullNameWithType(string name)
    {
        var type = GetType();
        return type.Name.StartsWith(QilinProcessorTypePrefix)
            ? $"{QilinProcessorTypePrefix}.{name}"
            : $"{PublicProcessorTypePrefix}.{name}";
    }
}