using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace RemotingserviceHostt
{
	 class Program
	{
		static void Main()
		{
			HelloRemotingservicee.HelloRemotingService remoting = new
				HelloRemotingservicee.HelloRemotingService();
			TcpChannel channel = new TcpChannel(8080);
			ChannelServices.RegisterChannel(channel);
			RemotingConfiguration.RegisterWellKnownServiceType
				(typeof(HelloRemotingservicee.HelloRemotingService),"GetMessage", WellKnownObjectMode.SingleCall);
			Console.WriteLine("Remotig service started @" + DateTime.Now);
			Console.ReadLine();
		}
	}
}
