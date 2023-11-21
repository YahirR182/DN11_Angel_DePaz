using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {

        private static List<Member> Members = new List<Member>();


        public int AddMember(Member member)
        {
            member.Id = new Random().Next();
            Members.Add(member);
            return member.Id;
        }

        public List<Member> GetMembers()
        {
            return Members;
        }
    }
}

