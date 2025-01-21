using Newtonsoft.Json.Linq;
using Qilin.Core.PipelineProcessor.Abstractions.Exceptions;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Extensions;

public static class ProcessorDynamicValueExtension
{
    public static object? GetValue(this ProcessorDynamicValue dynamicValue, JObject? jObject = null)
    {
        ValidateRawAndPath(dynamicValue);

        if (dynamicValue.Raw is not null) return dynamicValue.Raw;

        if (jObject is null)
        {
            throw new ProcessorDynamicValueException("Input object is required");
        }

        // TODO: need to convert to ExpandoObject to not depend on Newtonsoft.Json
        return jObject.SelectToken(dynamicValue.Path!);
    }

    public static T? GetValue<T>(this ProcessorDynamicValue dynamicValue, JObject? jObject = null)
    {
        var value = dynamicValue.GetValue(jObject);

        try
        {
            if (value is JToken token)
            {
                return token.ToObject<T>();
            }

            return (T?)Convert.ChangeType(value, typeof(T));
        }
        catch (Exception e) when (e is InvalidCastException or FormatException)
        {
            throw new ProcessorDynamicValueException("Value is invalid", e);
        }
    }
    
    public static object GetRequiredValue(this ProcessorDynamicValue dynamicValue, JObject? jObject = null)
    {
        var value = dynamicValue.GetValue(jObject);

        if (value is null)
        {
            throw new ProcessorDynamicValueException("Value is required");
        }

        return value;
    }
    
    public static T GetRequiredValue<T>(this ProcessorDynamicValue dynamicValue, JObject? jObject = null)
    {
        var value = dynamicValue.GetValue<T>(jObject);
        
        if (value is null)
        {
            throw new ProcessorDynamicValueException("Value is required");
        }

        return value;
    }

    private static void ValidateRawAndPath(ProcessorDynamicValue dynamicValue)
    {
        if (dynamicValue.Raw is not null && dynamicValue.Path is not null)
        {
            throw new ProcessorDynamicValueException("Dynamic value can not obtain multiple values");
        }

        if (dynamicValue.Raw is null && dynamicValue.Path is null)
        {
            throw new ProcessorDynamicValueException("Value is required");
        }
    }
}