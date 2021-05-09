using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;
using NLog.Config;

namespace StoryManager
{
    public class Configuration
    {
        string _config_path;
        string _storyList_path;

        public string StoryList_Path
        {
            get
            {
                return _storyList_path;
            }
        }

        public Configuration(string path)
        {
            _config_path = path;
        }
        public bool Load()
        {
            bool success = true;
            try
            {
                using (StreamReader sr = new StreamReader(_config_path))
                {
                    _storyList_path = sr.ReadLine();
                }
            }
            catch
            {
                success = false;
            }
            return success;
        }
    }
}
