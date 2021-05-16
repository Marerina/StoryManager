using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryManager
{
    class NewCharacter
    {
        Character _character;
        string _details;

        public NewCharacter(Character newCharacter, string details)
        {
            _character = newCharacter;
            _details = details;
        }
    }
    class Chapter
    {
        string _name;
        int _episodeNum;
        Files _doc;
        string _description;

        public string Name { get { return _name; } set { _name = value; } }
        public int Num { get { return _episodeNum; } set { _episodeNum = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Files Doc { get { return _doc; } set { _doc = value; } }

    }
    class Episode
    {
        string _name;
        int _part;
        Files _doc;
        string _description;
        List<NewCharacter> _newCharacters;
        

        public Episode(string name)
        {
            _name = name;
            _newCharacters = new List<NewCharacter>();
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Part { get { return _part; } set { _part = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public List<NewCharacter> NewCharacters { get { return _newCharacters; } set { _newCharacters = value; } }
        public Files Doc { get { return _doc; } set { _doc = value; } }

        public void AddCharacter(Character character, string description)
        {
            NewCharacter newCharacter = new NewCharacter(character, description);
            _newCharacters.Add(newCharacter);
        }
    }

    class StoryLine
    {
        List<Episode> episodes;
        List<Chapter> chapters;
        string _name;
        Link _folder;
        public StoryLine(Link link)
        {
            Name = link.Name;
            _folder = link;
        }
        public string Name { get { return _name; } set { _name = value; } }

    }
}
