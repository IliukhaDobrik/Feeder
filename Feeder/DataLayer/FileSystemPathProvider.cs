using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class FileSystemPathProvider : IFileSystemPathProvider
    {
        public string GetFeedersPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Jsons", "Feeders.json");
        }

        public string GetLogsPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Jsons", "Logs.json");
        }

        public string GetUsersPath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "Jsons", "Users.json");
        }
    }
}
