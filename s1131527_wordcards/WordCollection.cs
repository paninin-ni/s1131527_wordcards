using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1131527_wordcards
{
    internal class WordCollection : Collection<WordItem>
    {
        public void LoadFromStringArray(string[] lines)
        {
            this.Clear();
            // 將字串陣列的資料載入到 WordCollection 物件中
            foreach (string line in lines)
            {
                // 產生 WordItem 物件
                WordItem item = new WordItem(line);
                this.Add(item);
            }
        }
    }
}
