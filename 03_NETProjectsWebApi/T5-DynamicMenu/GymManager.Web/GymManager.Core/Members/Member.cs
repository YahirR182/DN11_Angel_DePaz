using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Core.Members
{
	public class Member
	{
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public required string Name { get; set; }
        [StringLength(20)]
        [Required]
        public required string LastName { get; set; }
        [BindProperty ,DisplayFormat(DataFormatString="(0:dd-MM-yyyy)",ApplyFormatInEditMode=true)]
        public DateTime BirthDay { get; set; }
        [Range(1,51)]
        public int CityId { get; set; }
        [EmailAddress]
        [Required]
        public required string Email { get; set; }
        public bool AllowNewsLetter { get; set; }

    }
}

