using JobScheduler.Application.Interfaces;
using JobScheduler.Domain.Entities;
using JobScheduler.Domain.Enums;
using RazorLight;

namespace JobScheduler.Application.Services
{
    public class JobTemplateRenderer : ISqlRenderer
    {
        private readonly RazorLightEngine _engine;

        public JobTemplateRenderer()
        {
            _engine = new RazorLightEngineBuilder()
                .UseMemoryCachingProvider()
                .Build();
        }

        public async Task<string> RenderAsync(Job job)
        {
            if (job.Type == JobType.Custom) return job.RawSql ?? "";

            var template = job.TemplateId ?? throw new Exception("Template not found");
            var model = job.Mappings.ToDictionary(m => m.AliasKey, m => (object)m.MappedValue);
            return await _engine.CompileRenderAsync("templateKey", model);
        }
    }
}