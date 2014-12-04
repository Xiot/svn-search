using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SvnSearchUI.Layout;
using SvnSearchUI.Services;

namespace SvnSearchUI.Installers
{
	public class ServiceInstaller : IWindsorInstaller 
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<EventSource>());
			container.Register(Component.For<RootViewModel>());
		}
	}
}
