using AOPWebApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AOPWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private IFeatureService Feature { get; }
        private IFeature2Service Feature2 { get; }

        public FeatureController(IFeatureService feature, IFeature2Service feature2Service)
        {
            Feature = feature;
            Feature2 = feature2Service;

        }

        // POST api/<FeatureController>
        [HttpGet("Feature-Feat1")]
        public void FeatureFeat1()
        {
            Feature.Feat1();
        }

        [HttpGet("Feature-Feat2")]
        public void FeatureFeat2()
        {
            Feature.Feat2();
        }


        [HttpGet("Feature2-Feat1")]
        public void Feature2Feat1()
        {
            Feature2.Feat1();
        }

        [HttpGet("Feature2-Feat2")]
        public void Feature2Feat2()
        {
            Feature2.Feat2();
        }


    }
}
