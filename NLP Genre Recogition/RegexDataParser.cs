using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NLP_Genre_Recogition
{
    class RegexDataParser
    {
        Regex[] regularExpressions = new Regex[7];


        public RegexDataParser()
        {
            regularExpressions[0] = new Regex("<.*?>", RegexOptions.Compiled);
            regularExpressions[1] = new Regex("[.*?]", RegexOptions.Compiled);
            regularExpressions[2] = new Regex("(.*?)", RegexOptions.Compiled);
            regularExpressions[3] = new Regex("\\p{P}", RegexOptions.Compiled);
            regularExpressions[4] = new Regex("\\n", RegexOptions.Compiled);
            regularExpressions[5] = new Regex("\\r", RegexOptions.Compiled);
            regularExpressions[6] = new Regex("[^a-zA-Z]+", RegexOptions.Compiled);
            // Add more if needed
           
        }

        public String StripTagsRegexCompiled(String Lyrics)
        {
           Lyrics =  regularExpressions[0].Replace(Lyrics," ");
           Lyrics = regularExpressions[1].Replace(Lyrics, " ");
           Lyrics = regularExpressions[2].Replace(Lyrics, string.Empty);
           Lyrics = regularExpressions[3].Replace(Lyrics, string.Empty);
           Lyrics =  regularExpressions[4].Replace(Lyrics, string.Empty);
           Lyrics = regularExpressions[5].Replace(Lyrics, string.Empty);
           Lyrics = regularExpressions[6].Replace(Lyrics, " ");
           
           return Lyrics.ToLower();
        }
    }
}
