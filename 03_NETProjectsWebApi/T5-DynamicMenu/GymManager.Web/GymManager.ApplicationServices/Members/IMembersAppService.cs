using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.Members
{
	public interface IMembersAppService
	{
		
		List<Member> GetMembers();

		int AddMember(Member member);


		void DeleteMember(int memberId);

		Member GetMember(int memberId);

		void EditMember(Member member);
	}
}

