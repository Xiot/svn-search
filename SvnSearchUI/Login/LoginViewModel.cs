using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microdea.Mvvm.Annotations;
using Microdea.Mvvm.Commands;
using PropertyChanged;

namespace SvnSearchUI.Login
{
	[ImplementPropertyChanged]
	public class LoginViewModel
	{

		#region Constructors
		public LoginViewModel()
		{
			this.LoginCommand = new RelayCommand<object>(OnLoginRequested);
		}
		#endregion

		#region Commands
		public ICommand LoginCommand { get; private set; }
		#endregion

		#region Public Properties
		public string RootUri { get; set; }

		public string Username { get; set; }
		public string Password { get; set; }
		public bool RememberMe { get; set; }
		#endregion

		#region Command Methods
		private void OnLoginRequested(object obj)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
