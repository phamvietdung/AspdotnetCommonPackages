using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspdotnetCommonPackages
{
    public static partial class TextExtensions
    {
        private static string specialRegexNeedReplace = @"\s|\-";
        private static string specialRegexNeedRemove = @"\!|\@|\#|\$|\%|\^";
        /// <summary>
        /// Unicode
        /// https://en.wikipedia.org/wiki/List_of_Unicode_characters
        /// 
        /// ASII
        /// https://www.w3schools.com/charsets/ref_html_ascii.asp
        /// </summary>
        private static Dictionary<string, string[]> alternativeCharacterList = new Dictionary<string, string[]>
        {
           {"a",new string[]{"á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ"}},
           {"d",new string[]{"đ"}},
           {"e",new string[]{"é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ"}},
           {"i",new string[]{"í","ì","ỉ","ĩ","ị"}},
           {"o",new string[]{"ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ"}},
           {"u",new string[]{"ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự"}},
           {"y",new string[]{"ý","ỳ","ỷ","ỹ","ỵ"}},
        };

        private static Dictionary<string, string> GetAlternativeList()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var pair in alternativeCharacterList)
            {
                result.Add(pair.Key, String.Join("", pair.Value));
            }

            return result;
        }

        private static string[] GetAlternativeCharacterList()
        {
            string[] result = new string[alternativeCharacterList.Sum(s => s.Value.Count())];

            int index = 0; // start node

            foreach(var pair in alternativeCharacterList)
            {
                for(var i = 0; i < pair.Value.Length; i++)
                {
                    result[index] = pair.Value[i];

                    index++;
                }
            }

            return result;
        }
    }
}
