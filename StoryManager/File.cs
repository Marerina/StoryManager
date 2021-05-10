using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AODL.Document.TextDocuments;
using LibreOfficeLibrary;
using System.IO;


namespace StoryManager
{
    public enum FileType{LibreOffice, Txt, Doc}
    public abstract class Files
    {
        Link _link;
        FileType _type;
        public Link Link { get { return _link; } set { _link = value; } }
        public FileType Type { get { return _type; } set { _type = value; } }

        public Files(Link link)
        {
            _link = link;
        }
        public Files()
        {
        }
        public abstract void Open();
        public abstract Link Create(string name);
    }
    class TxtFile : Files
    {
        public override void Open()
        {
            System.Diagnostics.Process.Start(Link.Path);
        }

        public override Link Create(string name)
        {
            //Create a new text document
            File.Create(name);
            Link = new Link("", name);
            System.Diagnostics.Process.Start(Link.Path);
            return Link;
        }

    }
    class LibreFile : Files
    {
        public override void Open()
        {
            /* TextDocument document = new TextDocument();
             document.Load(Link.Path);*/
            System.Diagnostics.Process.Start(Link.Path);
        }

        public override Link Create(string name)
        {
            //Create a new text document
            TextDocument document = new TextDocument();
            document.New();
            document.SaveTo(name);

            Link =  new Link("", name);
            System.Diagnostics.Process.Start(Link.Path);
            return Link;
        }
        
    }
}
