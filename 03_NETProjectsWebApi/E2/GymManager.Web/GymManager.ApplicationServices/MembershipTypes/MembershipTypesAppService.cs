using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypesAppService : IMembershipTypesAppService
    {
        private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public int AddMembershipType(MembershipType membershipType)
        {
            membershipType.ID = new Random().Next();
            MembershipTypes.Add(membershipType);
            return membershipType.ID;
        }

        public void DeleteMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.ID == membershipTypeId).FirstOrDefault();

            if (m != null)
            {
                MembershipTypes.Remove(m);
            }
        }

        public void EditMembershipType(MembershipType membershipType)
        {
            var m = MembershipTypes.Where(x => x.ID == membershipType.ID).FirstOrDefault();
            if (m != null)
            {
                m.Name = membershipType.Name;
                m.Cost = membershipType.Cost;
                m.Duration = membershipType.Duration;
                

            }
        }

        public MembershipType GetMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.ID == membershipTypeId).FirstOrDefault();
            if (m == null)
            {
                throw new InvalidOperationException("No se encontró ningún miembro con el memberId proporcionado.");
            }
            return m;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return MembershipTypes;
        }
    }
}

