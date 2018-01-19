using System;
using umayplusapi.Models;

namespace umayplusapi.Services
{
    public class MemberService
    {
        public MemberService()
        {

        }

		public Member GetMemberInfo(string umayplusCardID, string personalCardId, string birthDate, string mobilePhone)
		{


			var member = new Member
			{
				UmayplusCardID = "6273885053341539",
				PersonalCardID = "3100505143401",
				BirthDate = "01/01/2530",
				MobilePhone = "092224955",
				FirstName = "Phongsakorn",
				LastName = "Muenkham"
			};

			return member;
		}
    }
}