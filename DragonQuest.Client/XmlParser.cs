using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DragonQuestWFA.Client
{
    public interface IXlParser
    {
        //Xml檔案路徑
        string Path { get; set; }
        //根的位置
        string Root { get; set; }
        //解析Xml匯出Dictionary<Str, Str>的格式
        Dictionary<string, string> ToDictionaryStrStr();
        //解析Xml匯出Dictionary<Str, Int>的格式
        Dictionary<string, int> ToDictionaryStrInt();
        //解析Xml匯出List<Str>的格式
        List<string> ToListStr();
    }

    public class XmlParser : IXlParser
    {
        public string Path { get; set; }
        public string Root { get; set; }

        private IEnumerable<XElement> GetXElement()
        {
            XDocument _doc = XDocument.Load(Path);

            return _doc.XPathSelectElements(Root);
        }

        public Dictionary<string, string> ToDictionaryStrStr()
        {
            var _data = new Dictionary<string, string>();
            var _list = GetXElement();
            foreach (XElement _item in _list.Elements())
            {
                _data.Add(Convert.ToString(_item.Name), _item.Value);
            }

            return _data;
        }

        public Dictionary<string, int> ToDictionaryStrInt()
        {
            var _data = new Dictionary<string, int>();
            var _list = GetXElement();
            foreach (XElement _item in _list.Elements())
            {
                string _name = _item.Attribute("name").Value;
                int _value = int.Parse(_item.Attribute("value").Value);

                _data.Add(_name, _value);
            }

            return _data;
        }

        public List<string> ToListStr()
        {
            var _data = new List<string>();
            var _list = GetXElement();
            foreach (XElement _item in _list.Elements())
            {
                _data.Add(Convert.ToString(_item.Name));
            }

            return _data;
        }
    }
}
