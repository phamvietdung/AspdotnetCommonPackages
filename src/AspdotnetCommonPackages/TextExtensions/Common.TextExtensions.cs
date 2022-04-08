using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AspdotnetCommonPackages
{
    public static partial class TextExtensions
    {
        
        public static string ToAlias(this string source, bool convertToLowerCase = true, string alternativeCharacter = "_")
        {
            return source
                .ReplaceUnicodeCharacterByTheASIICharacter(convertToLowerCase)
                .ReplaceSpecialCharacterByUnderLineCharacter(alternativeCharacter);
        }

        public static string ReplaceUnicodeCharacterByTheASIICharacter(this string source, bool convertToLowerCase = true)
        {
            if (source.IsNull())
                return String.Empty;

            string[] chars = source.ToCharArray().Select(s => s.ToString().ToLower()).ToArray();

            Dictionary<string, string> alternative = GetAlternativeList();

            for(int i = 0; i < chars.Length; i++)
            {
                foreach(var pair in alternative)
                {
                    if (pair.Value.IndexOf(chars[i]) >= 0)
                        chars[i] = pair.Key;
                }
            }

            return String.Join("", convertToLowerCase ? chars.Select(s => s.ToLower()) : chars.Select(s =>s.ToUpper()));

        }

        public static string ReplaceSpecialCharacterByUnderLineCharacter(this string source, string alternativeCharacter = "_")
        {
            source = Regex.Replace(source, specialRegexNeedReplace, alternativeCharacter);

            source = Regex.Replace(source, specialRegexNeedRemove, String.Empty);

            return source;

        }

        /*
        * Masking some character in a string with alternative
        * character. Default is "*" but it can be change to
        * another. Make sure allways masking/hidden about 50%
        * to 60% information.
        */
        public static string Masking(this string source, string alternative_character = "*", int ratioHidden = 60)
        {
            if (source == null)
                return String.Empty;

            var total = source.Length;

            var total_masking = total * ratioHidden / 100;

            var start_at = (total - total_masking) / 2;

            var masking = "";

            for (var i = 0; i < total_masking; i++)
                masking += alternative_character;

            return source.Substring(0, start_at) + masking + source.Substring(start_at + total_masking, total - (start_at + total_masking));

        }
    }
}
