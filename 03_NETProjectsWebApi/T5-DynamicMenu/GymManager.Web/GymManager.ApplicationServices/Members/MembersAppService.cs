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

        public void DeleteMember(int memberId)
        {
            var  m = Members.Where(x=> x.Id==memberId).FirstOrDefault();

            if (m != null)
            {
                Members.Remove(m);
            }
        }

        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();
            if(m!=null)
            {
                m.AllowNewsLetter = member.AllowNewsLetter;
                m.BirthDay = member.BirthDay;
                m.CityId = member.CityId;
                m.Email = member.Email;
                m.Name = member.Name;
                m.LastName = member.LastName;
              
            }
           


        }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            if (m == null)
            {
                throw new InvalidOperationException("No se encontró ningún miembro con el memberId proporcionado.");
            }
            return m;
        }

        public List<Member> GetMembers()
        {
            return Members;
        }
    }
}

