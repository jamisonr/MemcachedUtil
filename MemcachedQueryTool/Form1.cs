using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using ExactTarget.Core.Caching;

namespace CacheUtils
{
	public partial class Form1 : Form
	{
		private const string Userprefs = "userproperties.xml";
		public Form1()
		{
			InitializeComponent();
		}

		private void DeleteServerToolStripMenuItemClick(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			InitUserPrefs();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void InitUserPrefs()
		{
			if (!File.Exists(Userprefs))
			{
				var writer = new XmlTextWriter(Userprefs, null);
				writer.WriteStartDocument();
				writer.WriteStartElement("UserProperties");
				writer.WriteEndElement();
				writer.WriteEndDocument();
				writer.Close();
			}
		}

		private void SaveSettings()
		{
			
		}

		public MemcachedClient GetClient(string hostname, int port)
		{
			var config = new MemcachedClientConfiguration();
			config.Servers.Add(new IPEndPoint(Dns.GetHostEntry(hostname).AddressList[0], port));
			config.SocketPool.ReceiveTimeout = new TimeSpan(0,0,15);
			return new MemcachedClient(config);
		}

		private void Log(string msg)
		{
			TimeSpan t = DateTime.Now.TimeOfDay;
			string time = string.Format("{0}:{1}:{2}.{3}", t.Hours, t.Minutes, t.Seconds,
			                            t.Milliseconds.ToString().Substring(0, 1)); 
			debug.Text =  time + "\t" + msg + "\r\n" + debug.Text;
		}

		private void SetButton_Click(object sender, EventArgs e)
		{
			var client = GetClient(tb_host.Text, Convert.ToInt32(tb_port.Text));
			var stored = client.Store(StoreMode.Set, keyTextBox.Text, valueTextBox.Text, new TimeSpan(1, 0, 0));
			if (stored)
				Log("stored key [" + keyTextBox.Text + "] >> " + valueTextBox.Text);
			else
				Log("failed to store " + keyTextBox.Text);
		}

		private void GetButton_Click(object sender, EventArgs e)
		{
            var val = GetClient(tb_host.Text, Convert.ToInt32(tb_port.Text)).Get(keyTextBox.Text) as string;
			Log("retrieved key [" + keyTextBox.Text + "] >> " + val);
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
            var val = GetClient(tb_host.Text, Convert.ToInt32(tb_port.Text)).Remove(keyTextBox.Text) as bool?;
			Log("delete key [" + keyTextBox.Text + "] succeeded >> " + val);
		}

		private void AddServerButton_Click(object sender, EventArgs e)
		{
			Log("not implemented");
		}

		private void clearDebugButton_Click(object sender, EventArgs e)
		{
			debug.Text = "";
		}

		private void flushButton_Click(object sender, EventArgs e)
		{
            GetClient(tb_host.Text, Convert.ToInt32(tb_port.Text)).FlushAll();
			Log(tb_host.Text + " cache was flushed");
		}

		private void statsButton_Click(object sender, EventArgs e)
		{
			//var cacheHost = hostsListBox.SelectedItem as CacheHost;
			//if (cacheHost != null)
			//{
			//  var endpoint = cacheHost.IPEndPoint;
			//  GetClient().Dispose();
			//  Log(GetStats(cacheHost));
			//  Log("--Stats for " + (hostsListBox.SelectedItem as CacheHost).Hostname + "--");
			//}
			Log("not implemented");
		}

		private string GetStats(CacheHost cacheHost)
		{
			var str = "stats";
			var retval = String.Empty;
			try
			{
				var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				var localIP = new IPEndPoint(IPAddress.Any, 8221);

				Send(sock, Encoding.UTF8.GetBytes(str), 0, str.Length, 10000);
				var buffer = new byte[200];
				Receive(sock, buffer, 0, buffer.Length, 10000);
				retval = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
			}catch(Exception ex)
			{
				Log(ex.Message);
			}
			return retval;
		}

		private MemcachedClient GetClient()
		{
            return GetClient(tb_host.Text, Convert.ToInt32(tb_port.Text));
		}

		public static void Send(Socket socket, byte[] buffer, int offset, int size, int timeout)
		{
			int startTickCount = Environment.TickCount;
			int sent = 0; // how many bytes is already sent
			do
			{
				if (Environment.TickCount > startTickCount + timeout)
					throw new Exception("Timeout.");
				try
				{
					sent += socket.Send(buffer, offset + sent, size - sent, SocketFlags.None);
				}
				catch (SocketException ex)
				{
					if (ex.SocketErrorCode == SocketError.WouldBlock ||
					    ex.SocketErrorCode == SocketError.IOPending ||
					    ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
					{
						// socket buffer is probably full, wait and try again
						Thread.Sleep(30);
					}
					else
						throw ex; // any serious error occurr
				}
			} while (sent < size);
		}

		public static void Receive(Socket socket, byte[] buffer, int offset, int size, int timeout)
		{
			int startTickCount = Environment.TickCount;
			int received = 0;  // how many bytes is already received
			do
			{
				if (Environment.TickCount > startTickCount + timeout)
					throw new Exception("Timeout.");
				try
				{
					received += socket.Receive(buffer, offset + received, size - received, SocketFlags.None);
				}
				catch (SocketException ex)
				{
					if (ex.SocketErrorCode == SocketError.WouldBlock ||
							ex.SocketErrorCode == SocketError.IOPending ||
							ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
					{
						// socket buffer is probably empty, wait and try again
						Thread.Sleep(30);
					}
					else
						throw ex;  // any serious error occurr
				}
			} while (received < size);
		}

	}
}
