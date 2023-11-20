using System;
using GymManager.Core.Members;

namespace GymManager.Web.Models
{
	public class MemberListViewModel
	{
		public int NewMembersCount { get; set; }
        public required List<Member> Members { get; set; }
	}
}

