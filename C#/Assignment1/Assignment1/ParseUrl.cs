using System;
namespace Assignment1
{
	public class ParseUrl
	{
		public void DisplayParseUrl(string url)
		{
            string protocol = "";
            string server = "";
            string resource = "";

            // Find protocol
            int protocolEndIndex = url.IndexOf("://");
            if (protocolEndIndex != -1)
            {
                protocol = url.Substring(0, protocolEndIndex);
                url = url.Substring(protocolEndIndex + 3);
            }

            // Find server
            int serverEndIndex = url.IndexOf('/');
            if (serverEndIndex != -1)
            {
                server = url.Substring(0, serverEndIndex);
                resource = url.Substring(serverEndIndex + 1);
            }
            else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
            Console.WriteLine();
        }
	}
}

