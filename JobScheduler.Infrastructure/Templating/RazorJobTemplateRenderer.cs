using RazorLight;

namespace JobScheduler.Infrastructure.Templating
{
    public class RazorJobTemplateRenderer
    {
        private readonly RazorLightEngine _engine;

        public RazorJobTemplateRenderer()
        {
            _engine = new RazorLightEngineBuilder()
                .UseMemoryCachingProvider()
                .Build();
        }

        public async Task<string> RenderAsync(string template, object model)
        {
            return await _engine.CompileRenderAsync<object>("templateKey", template);
        }
    }
}