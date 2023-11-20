using System;
using GymManager.Core.Members;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        public List<Member> GetMembers()
        {

            List<Member> members = new List<Member>();

            members.Add(new Member
            {
                Name = "Angel Yahir ",
                LastName = "De Paz Reyes",
                BirthDay = new DateTime(2003,01,16),
                AllowNewsLetter=true,
                CityId=1,
                Email="yahir_32@prueba.com"

            }) ;

            members.Add(new Member
            {
                Name = "Nili ",
                LastName = "Domínguez",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Jonatan  ",
                LastName = "Hernández",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });

            members.Add(new Member
            {
                Name = "Michelle ",
                LastName = "Navarrete",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Camila ",
                LastName = "García",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Metzli ",
                LastName = "Ávila",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Jorge",
                LastName = "Esquivel",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Michelle",
                LastName = "Zetina",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Alejandra",
                LastName = "Nava",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });
            members.Add(new Member
            {
                Name = "Diana",
                LastName = "Acósta",
                BirthDay = new DateTime(2003, 01, 16),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "yahir_32@prueba.com"

            });

            return members;
        }
    }
}

