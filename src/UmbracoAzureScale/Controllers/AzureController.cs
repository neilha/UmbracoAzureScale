using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace UmbracoAzureScale.Controllers
{
    public class AzureEnv
    {
        public string ComputerName { get; set; }
        public string InstanceId { get; set; }
    }

    [PluginController("azure")]
    public class EnvironmentController : UmbracoAuthorizedJsonController
    {
        [HttpGet]
        public IHttpActionResult GetServerEnvironment()
        {
            AzureEnv env = new AzureEnv
            {
                ComputerName = Environment.GetEnvironmentVariable("COMPUTERNAME"),
                InstanceId = Environment.GetEnvironmentVariable("WEBSITE_INSTANCE_ID")
            };

            return Ok(env);
        }
    }
}