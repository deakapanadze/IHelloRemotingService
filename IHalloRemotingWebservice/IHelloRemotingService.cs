using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHalloRemotingWebservice
{
	public interface IHelloRemotingService
	{
		string GetMessage(string name); 
	}
}
