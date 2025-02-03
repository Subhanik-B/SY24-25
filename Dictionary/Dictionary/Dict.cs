using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Dict
    {
        List<string> dictionamary = new List<string>();
        List<string> definitions = new List<string>();
        public void addWord(String word, String definition)
        {
            dictionamary.Add(word);
            definitions.Add(definition);
        }

        public String getDefinition(String word)
        {
            for (int i = 0; i < dictionamary.LongCount(); i++)
            {
                if (dictionamary[i].Equals(word))
                {
                    return definitions[i];
                }
            }
            return null;
        }
    }
}
