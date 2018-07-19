using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string output = "";
            Dictionary<char, char> DnaRnadict = new Dictionary<char, char>(){ {'G','C'}, {'C', 'G'}, {'T','A'}, {'A','U'} };
            for(int i=0; i< nucleotide.Length; i+=1)
            {
                output += DnaRnadict[nucleotide[i]];
            }
            return output;
            //throw new NotImplementedException("You need to implement this function.");
        }
    }
}
