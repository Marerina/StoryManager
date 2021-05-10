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
    class Episode
    {
        string _name;
        int _part;
        Link _doc;
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
        public void AddCharacter(Character character, string description)
        {
            NewCharacter newCharacter = new NewCharacter(character, description);
            _newCharacters.Add(newCharacter);
        }
    }
    class StoryLine
    {
        List<Episode> episodes;


    }
}
