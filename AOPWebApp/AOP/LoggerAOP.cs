using System.Threading.Tasks;
using AspectCore.DynamicProxy;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace AOPWebApp.AOP
{
    public class LoggerAOP : AbstractInterceptorAttribute
    {
        public LoggerAOP()
        {

        }

        public async override Task Invoke(AspectContext context, AspectDelegate next) 
        {
            var logger = context.ServiceProvider.GetService<ILogger<LoggerAOP>>();

            logger.LogInformation($"Before { context.ImplementationMethod.DeclaringType.FullName}.{ context.ImplementationMethod.Name}");

            await next(context);

            logger.LogInformation($"After { context.ImplementationMethod.DeclaringType.FullName}.{ context.ImplementationMethod.Name}");
        }
    }
}
