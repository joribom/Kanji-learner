using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;

namespace Kanji_learner
{
    class Lesson
    {
        private List<String> kanji;
        private List<String> original_list;
        private Dictionary<String, String> strokes = new Dictionary<String, String>();
        private Dictionary<String, String> meaning = new Dictionary<String, String>();
        private Dictionary<String, String> onyomi = new Dictionary<String, String>();
        private Dictionary<String, String> kunyomi = new Dictionary<String, String>();
        private String fileName;
        private int currentKanjiNumber;
        private bool isKanji;
        Random random = new Random();
        Regex wordMatch = new Regex(@"[\w\-]+");

        public Lesson(String fileName, bool isKanji)
        {
            this.isKanji = isKanji;
            this.fileName = fileName;
   
            kanji = new List<String>();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode dataset = doc.SelectSingleNode("data-set");
            currentKanjiNumber = 0;

            String currentKanji;
            String[] currentValues;

            foreach (XmlNode entryNode in dataset.ChildNodes)
            {
                currentValues = new String[4];
                currentKanji = entryNode.SelectSingleNode("Kanji").InnerText;
                kanji.Add(currentKanji);
                strokes.Add(currentKanji, entryNode.SelectSingleNode("Strokes") != null ? entryNode.SelectSingleNode("Strokes").InnerText : "");
                meaning.Add(currentKanji, entryNode.SelectSingleNode("Meaning") != null ? entryNode.SelectSingleNode("Meaning").InnerText : "");
                onyomi.Add(currentKanji, entryNode.SelectSingleNode("Onyomi") != null ? entryNode.SelectSingleNode("Onyomi").InnerText : "");
                kunyomi.Add(currentKanji, entryNode.SelectSingleNode("Kunyomi") != null ? entryNode.SelectSingleNode("Kunyomi").InnerText : "");
            }
            foreach (String singlekanji in kanji)
            {
                Console.WriteLine(String.Format("{0}: {1}, {2}, {3}, {4}", singlekanji, strokes[singlekanji], meaning[singlekanji], onyomi[singlekanji], kunyomi[singlekanji]));
            }
            original_list = (kanji);
        }

        public bool isKanjiLesson()
        {
            return isKanji;
        }

        public String getFileName()
        {
            return this.fileName;
        }

        public void selectRandomKanji()
        {
            int number = random.Next(kanji.Count);
            currentKanjiNumber = number;
        }

        public void selectNextKanji()
        {
            currentKanjiNumber++;
            if (currentKanjiNumber >= kanji.Count)
            {
                currentKanjiNumber = 0;
            }
        }

        public void currentKanjiPassed()
        {
            kanji.RemoveAt(currentKanjiNumber);
        }

        public String getKanji()
        {
            return kanji[currentKanjiNumber];
        }

        public String getStrokesForCurrentKanji()
        {
            return strokes[kanji[currentKanjiNumber]];
        }

        public String getMeaningForCurrentKanji()
        {
            return meaning[kanji[currentKanjiNumber]];
        }

        public String getOnyomiForCurrentKanji()
        {
            return onyomi[kanji[currentKanjiNumber]];
        }

        public String getKunyomiForCurrentKanji()
        {
            return kunyomi[kanji[currentKanjiNumber]];
        }


        private bool correctString(String inputString, String passString)
        {
            foreach (Match currentPassString in wordMatch.Matches(passString))
            {
                if (string.Compare(inputString, currentPassString.Value, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool correctOnyomi(String onyomiInput)
        { 
            if (!wordMatch.IsMatch(onyomiInput))
            {
                return false;
            }
            
            foreach (Match onyomiString in wordMatch.Matches(onyomiInput))
            {
                if (!correctString(onyomiString.Value, this.getOnyomiForCurrentKanji()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool correctKunyomi(String kunyomiInput)
        {
            if (!wordMatch.IsMatch(kunyomiInput))
            {
                return false;
            }

            foreach (Match kunyomiString in wordMatch.Matches(kunyomiInput))
            {
                if (!correctString(kunyomiString.Value, this.getKunyomiForCurrentKanji()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool correctRomaji(String romajiInput)
        {

            if (!wordMatch.IsMatch(romajiInput))
            {
                return false;
            }

            foreach (Match romajiString in wordMatch.Matches(romajiInput))
            {
                if (!correctString(romajiString.Value, this.getOnyomiForCurrentKanji()) && !correctString(romajiString.Value, this.getKunyomiForCurrentKanji()))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool correctTranslation(String translationInput)
        {
            if (!wordMatch.IsMatch(translationInput))
            {
                return false;
            }

            foreach (Match translationString in wordMatch.Matches(translationInput))
            {
                if (!correctString(translationString.Value, this.getMeaningForCurrentKanji()))
                {
                    return false;
                }
            }

            return true;
        }

        public void failAtCurrentKanji()
        {

        }

    }
}
