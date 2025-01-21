using Newtonsoft.Json.Linq;
using Qilin.Core.PipelineProcessor.Abstractions.Models;

namespace Qilin.Core.PipelineProcessor.Abstractions.Interfaces;

public interface IPipelineProcessorConverterStrategy
{
    PipelineProcessorConfig ConverterToPipelineProcessor(JObject jObject);
}