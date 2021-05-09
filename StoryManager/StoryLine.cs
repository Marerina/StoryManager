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

    }
    class Episode
    {
        string _name;
        Link _doc;
        string _description;
        List<NewCharacter> newCharacters;

        public Episode(string name)
        {
            _name = name;
            newCharacters = new List<NewCharacter>();
        }
        public void AddCharacter(Character character)
        {

        }
    }
    class StoryLine
    {
    }
}
