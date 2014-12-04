using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using SvnSearchUI.Login;

namespace SvnSearchUI.Layout
{
	[ImplementPropertyChanged]
	public class RootViewModel
	{
		public RootViewModel()
		{
			this.CurrentViewModel = new LoginViewModel();
		}

		public object CurrentViewModel { get; set; }

	}
}
