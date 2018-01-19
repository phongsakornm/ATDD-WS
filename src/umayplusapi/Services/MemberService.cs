using System;
using umayplusapi.Contexts;
using umayplusapi.Models;

namespace umayplusapi.Services
{
    public class MemberService : IMemberService
    {
		private IMemberContext memberContext;

		public MemberService(IMemberContext memberContext)
        {
			this.memberContext = memberContext;
        }

		public Member FindMember(string umayplusCardID, string personalCardId)
		{
			throw new NotImplementedException();
		}

		public Member GetMemberInfo(string umayplusCardID, string personalCardID, string birthDate, string mobilePhone)
		{
			Member member = memberContext.FindMember(umayplusCardID, personalCardID);

			//var member = new Member
			//{
			//	UmayplusCardID = "6273885053341539",
			//	PersonalCardID = "3100505143401",
			//	BirthDate = "01/01/2530",
			//	MobilePhone = "092224955",
			//	FirstName = "Phongsakorn",
			//	LastName = "Muenkham"
			//};

			return member;
		}
    }
}