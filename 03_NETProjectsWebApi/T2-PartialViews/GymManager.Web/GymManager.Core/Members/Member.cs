using System;
namespace GymManager.Core.Members
{
	public class Member
	{
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int CityId { get; set; }
        public required string Email { get; set; }
        public bool AllowNewsLetter { get; set; }

    }
}

