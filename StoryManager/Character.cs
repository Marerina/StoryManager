using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StoryManager
{
    public enum FieldType { Строка, Число, Логическое, Дата, Файл }
    public class Field
    {
        FieldType _type;
        string _name;
        string _string_value;
        bool _bool_value;
        float _float_value;
        DateTime _datetime_value;
        Files _files_value;
        public Field(string name, string value)
        {
            _type = FieldType.Строка;
            _string_value = value;
            _name = name;
        }
        public Field(string name, float value)
        {
            _type = FieldType.Число;
            _float_value = value;
            _name = name;
        }
        public Field(string name, int value)
        {
            _type = FieldType.Число;
            _float_value = value;
            _name = name;
        }
        public Field(string name, bool value)
        {
            _type = FieldType.Логическое;
            _bool_value = value;
            _name = name;
        }
        public Field(string name, DateTime value)
        {
            _type = FieldType.Дата;
            _datetime_value = value;
            _name = name;
        }
        public Field(string name, Files value)
        {
            _type = FieldType.Файл;
            _files_value = value;
            _name = name;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public object GetValue()
        {
            object o = null;
            switch (_type)
            {
                case (FieldType.Дата):
                    {
                        o = (object)_datetime_value;
                        break;
                    }
                case (FieldType.Логическое):
                    {
                        o = (object)_bool_value;
                        break;
                    }
                case (FieldType.Строка):
                    {
                        o = (object)_string_value;
                        break;
                    }
                case (FieldType.Число):
                    {
                        o = (object)_float_value;
                        break;
                    }
                case (FieldType.Файл):
                    {
                        o = (object)_files_value;
                        break;
                    }
            }
            return o;
        }
    }
    public class Link
    {
        string _name;
        string _path;
        public string Name { get { return _name; } set { _name = value; }  }
        public string Path { get { return _path; } set { _path = value; } }
        public Link(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public static bool Check(string path)
        {
            return File.Exists(path);
        }
        public  bool Check()
        {
            return File.Exists(Path);
        }
    }
    class Character
    {
        string _name;
        List<Field> _fieldList;

        public Character(string name)
        {
            _name = name;
            _fieldList = new List<Field>();
        }
        public Character(string name, List<Field> fields)
        {
            _name = name;
            _fieldList = fields;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public List<Field> Fields { get { return _fieldList; } set { _fieldList = value; } }

    }
}