﻿using Autofac;

namespace BlogsApp.Core
{

	public class ModuloCore : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<ContextFactory>().AsSelf().SingleInstance();
		}
	}
}
