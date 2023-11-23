using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DataAccess
{
	public class GymManagerContext:IdentityDbContext
	{
		public GymManagerContext(DbContextOptions<GymManagerContext> options):base(options)
		{

		}
	}
}
