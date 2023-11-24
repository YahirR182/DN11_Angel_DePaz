using System;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Core.Members
{
	public class MembershipType
	{

		public int ID { get; set; }
		[Required]
        [StringLength(100)]
		public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        public double Cost { get; set; }
        [Required]
        [Editable(false)]
        public DateTime CreatedOn { get; set; } = DateTime.Now; 
        [Required]
        [Range(1,12)]
        public int Duration { get; set; }




	}
}

