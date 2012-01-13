using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CacheUtils
{
	public class CacheHost
	{
		public CacheHost(string display, string hostname, string port)
		{
			this.Display = display;
			this.Hostname = hostname;
			this.Port = port;
		}
		public string Display { get; set; }
		public string Hostname { get; set; }
		public string Port { get; set; }
		public override string ToString()
		{
			return this.Display;
		}

		public IPEndPoint IPEndPoint
		{
			get {
				return new IPEndPoint(Dns.GetHostEntry(Hostname).AddressList[0], Int32.Parse(Port));
			}
		}
	}
}
