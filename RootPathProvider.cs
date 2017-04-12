using Nancy;
using System.IO;

namespace dotnetdaveCore
{
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}