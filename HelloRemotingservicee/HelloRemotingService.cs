using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloRemotingservicee
{
	public class HelloRemotingService : MarshalByRefObject, 
		IHalloRemotingWebservice.IHelloRemotingService
	{
		public string GetMessage(string name)
		{
			return "hello " + name;
		}
	} 
}
