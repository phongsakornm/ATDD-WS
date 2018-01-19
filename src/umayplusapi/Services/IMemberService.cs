using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using umayplusapi.Models;

namespace umayplusapi.Services
{
    public interface IMemberService
    {
		Member GetMemberInfo(string umayplusCardID, string personalCardID, string birthDate, string mobilePhone);
	}
}
