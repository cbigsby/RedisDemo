using IQ.Phoenix.ServiceClient.Common;

namespace RedisDemo.Auth
{
    public class HardCodedTokenSource : IGetAuthToken
    {
        public string GetToken()
        {
            return "FILL THIS OUT";
        }
    }
}