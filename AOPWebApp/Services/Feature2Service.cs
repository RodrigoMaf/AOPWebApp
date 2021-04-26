using AOPWebApp.AOP;
using Microsoft.Extensions.Logging;

namespace AOPWebApp.Services
{
    public interface IFeature2Service 
    {
        
        public void Feat1();
        public void Feat2();
    }

    public class Feature2Service : IFeature2Service
    {
        private ILogger<Feature2Service> Logger { get; }
        public Feature2Service(ILogger<Feature2Service> logger)
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
