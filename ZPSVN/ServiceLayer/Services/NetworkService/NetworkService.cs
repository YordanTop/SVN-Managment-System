using System.Net.NetworkInformation;

namespace ServiceLayer.Services
{
    public class NetworkService : IService
    {
        public static bool IsOnline()
        {
            string host = "www.google.com";  
            Ping ping = new Ping();

            PingReply pingReply = ping.Send(host);

            if(pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }
    }
}
