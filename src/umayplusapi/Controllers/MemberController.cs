using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using umayplusapi.Models;
using umayplusapi.Services;

namespace umayplusapi.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
		private IMemberService memberService;
		public MemberController(IMemberService memberService) {
			this.memberService = memberService;
		}

        // POST api/<controller>
        [HttpPost]
        public ResponseMessage Post([FromBody]Member member)
        {
			//MemberService memberService = new MemberService();
			Member returnMember = memberService.GetMemberInfo(member.UmayplusCardID, member.PersonalCardID, member.BirthDate, member.MobilePhone);

			return new ResponseMessage() {
				Status = "200",
				Message = "NULL",
				data = returnMember
			};
        }
    }
}
