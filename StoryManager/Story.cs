using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryManager
{
    class Story
    {
        string _name;
        string _path;
        List<Character> _characters;
        List<StoryLine> _lines;
        List<Chapter> _chapters;
        public string Name { get { return _name; } set { _name = value; } }
        public string Path { get { return _path; } set { _path = value; } }
        public List<Character> Chatacters { get { return _characters; } set { _characters = value; } }
        public List<StoryLine> StoryLines { get { return _lines; } set { _lines = value; } }
        public List<Chapter> Chapters { get { return _chapters; } set { _chapters = value; } }

    }
}
