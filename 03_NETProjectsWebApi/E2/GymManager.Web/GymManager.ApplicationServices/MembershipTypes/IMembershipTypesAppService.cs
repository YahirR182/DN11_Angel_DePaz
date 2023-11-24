using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.MembershipTypes
{
	public interface IMembershipTypesAppService
	{
        List<MembershipType> GetMembershipTypes();

        int AddMembershipType(MembershipType membershipType);


        void DeleteMembershipType(int membershipTypeId);

        MembershipType GetMembershipType(int membershipTypeId);

        void EditMembershipType(MembershipType membershipType);
    }
}

