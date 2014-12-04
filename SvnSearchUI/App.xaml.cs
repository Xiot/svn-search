using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Castle.Windsor;
using Castle.Windsor.Installer;
using SvnSearchUI.Layout;

namespace SvnSearchUI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			var container = new WindsorContainer();
			container.Install(FromAssembly.This());

			var root = container.Resolve<RootViewModel>();			
			this.MainWindow = new MainWindow();
			this.MainWindow.DataContext = root;

			base.OnStartup(e);
			this.MainWindow.Show();
			
		}
	}
}
