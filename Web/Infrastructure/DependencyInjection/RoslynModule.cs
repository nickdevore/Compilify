﻿using Autofac;
using Compilify.Services;

namespace Compilify.Web.Infrastructure.DependencyInjection
{
    public class RoslynModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CSharpCompilationProvider>().As<ICodeEvaluator>();
            builder.RegisterType<CSharpValidator>().As<ICodeValidator>();
        }
    }
}