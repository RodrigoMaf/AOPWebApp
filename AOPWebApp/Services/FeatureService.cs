using AOPWebApp.AOP;
using Microsoft.Extensions.Logging;

namespace AOPWebApp.Services
{
    public interface IFeatureService 
    {
        
        public void Feat1();
        public void Feat2();
    }

    public class FeatureService : IFeatureService
    {
        private ILogger<FeatureService> Logger { get; }
        public FeatureService(ILogger<FeatureService> logger)
        {
            Logger = logger;
        }

        
        public void Feat1()
        {
            Logger.LogInformation($"Processing { GetType().FullName}.Feat1");
        }

        public void Feat2()
        {
            Logger.LogInformation($"Processing { GetType().FullName}.Feat2");
        }
    }
}
