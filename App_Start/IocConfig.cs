using Autofac;
using Autofac.Integration.WebApi;
using MediatR.Extensions.Autofac.DependencyInjection;
using SchoolApiFramewirk.Interfaces;
using SchoolApiFramewirk.Queries;
using SchoolApiFramewirk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace SchoolApiFramewirk.App_Start
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<StudentService>().As<IStudentService>().InstancePerRequest();
            builder.RegisterType<GroupService>().As<IGroupService>().InstancePerRequest();
            builder.RegisterMediatR(typeof(GetAllStudentsQuery).Assembly);

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}