using System;
using System.Threading.Tasks;

namespace DeepLinkDemo1
{
    public interface IAppHandler
    {
        Task<bool> LaunchApp(string uri);
    }
}
