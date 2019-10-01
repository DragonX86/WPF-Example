using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bk_tree
{
    class Sheet
    {
        public string Word { get; set; }
        public HybridDictionary Children { get; set; }

        public Sheet() { }

        public Sheet(string word)
        {
            this.Word = word.ToLower();
        }

        public Sheet this[int key]
        {
            get { return (Sheet)Children[key]; }
        }

        public ICollection Keys
        {
            get
            {
                if (Children == null)
                    return new ArrayList();
                return Children.Keys;
            }
        }

        public bool ContainsKey(int key)
        {
            return Children != null && Children.Contains(key);
        }

        public void AddChild(int key, string word)
        {
            if (this.Children == null)
                Children = new HybridDictionary();
            this.Children[key] = new Sheet(word);
        }
    }
}
