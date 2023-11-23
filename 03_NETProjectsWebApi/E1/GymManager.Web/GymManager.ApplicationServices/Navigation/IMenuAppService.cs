using System;
using GymManager.Core.Navigation;

namespace GymManager.ApplicationServices.Navigation
{
	public interface IMenuAppService
	{

		List<UserMenuItem> GetMenu();

	}
}

