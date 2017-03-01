using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;

using ezQ.Api.Infrastructure;
using ezQ.Core.Services;
//using ezQ.Services;


namespace ezQ.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //DI Configuration
            var container = new UnityContainer();
            container.RegisterType<ITestService, TestService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API configuration and services
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


            // Web API routes - attribute routing
            config.MapHttpAttributeRoutes();

            //Conventional routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}