using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace HelloRemotingServiceClient
{
	public partial class Form1 : Form
	{
		IHalloRemotingWebservice.IHelloRemotingService Client;
		public Form1()
		{
			InitializeComponent();
			TcpChannel channel = new TcpChannel();
			ChannelServices.RegisterChannel(channel);
			Client = (IHalloRemotingWebservice.IHelloRemotingService)Activator.GetObject(
				typeof(IHalloRemotingWebservice.IHelloRemotingService), "tcp://localhost:8080/GetMessage");
		}

		private void Btn_getmessage_Click(object sender, EventArgs e)
		{
			label1.Text = Client.GetMessage(textBox1.Text);

		}
	}
}
