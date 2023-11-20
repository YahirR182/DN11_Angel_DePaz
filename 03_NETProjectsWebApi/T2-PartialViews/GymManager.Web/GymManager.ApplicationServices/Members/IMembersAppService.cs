using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.Members
{
	public interface IMembersAppService
	{
		
		List<Member> GetMembers();

	}
}

