using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace umayplusapi.Models
{
    public class ResponseMessage
    {
		public string Status { get; set; }

		public string Message { get; set; }

		public Member data { get; set; }
	}
}
