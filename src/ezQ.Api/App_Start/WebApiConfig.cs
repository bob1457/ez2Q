using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;

using ezQ.Api.Infrastructure;
using ezQ.Core.Interfaces;
using ezQ.Core.Services;
using ezQ.Data.Repositories;
using ezQ.Services.Interfaces;
using ezQ.Services.Services;


namespace ezQ.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //DI Configuration
            var container = new UnityContainer();

            //Services
            //
            container.RegisterType<ITestService, TestService>(new HierarchicalLifetimeManager());
            container.RegisterType<IClinicService, ClinicService>(new HierarchicalLifetimeManager());
            container.RegisterType<IClinicApplicationService, ClinicApplicationService>(new HierarchicalLifetimeManager());


            //Repositories
            //
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IClinicPatientRepository, ClinicPatientRepository>(new HierarchicalLifetimeManager());


            //Resolver
            //
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