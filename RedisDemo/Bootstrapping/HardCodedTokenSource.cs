using IQ.Phoenix.ServiceClient.Common;

namespace RedisDemo.Bootstrapping
{
    public class HardCodedTokenSource : IGetAuthToken
    {
        public string GetToken()
        {
            return "FILL THIS OUT";
        }
    }
}