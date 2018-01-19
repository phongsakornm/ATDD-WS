using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using umayplusapi.Models;
using umayplusapi.Contexts;

namespace umayplusapi.Contexts
{
    public class MemberContext : DbContext, IMemberContext
    {
		public MemberContext(DbContextOptions<MemberContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		public DbSet<Member> Members { get; set; }

		public Member FindMember(string umayplusCardID, string personalCardID)
		{
			return this.Members.Where(m => m.UmayplusCardID == umayplusCardID && m.PersonalCardID == personalCardID).First();
		}
	}

}
