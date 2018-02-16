using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
using RepeatCounter.Models;
using System;

namespace RepeatCounter.Models
{
    public class RepeatCounterCreator
    {
        private string _phrase;
        private string _check;

        public RepeatCounterCreator(string phrase, string check)
        {
            _phrase = phrase;
            _check = check;
        }

        public string GetPhrase()
        {
            return _phrase;
        }

        public string GetCheck()
        {
            return _check;
        }

        public static class CountTool
        {
            public static int CountStringOccurences(string _phrase, string _check)
            {
                int count = 0;
                int i = 0;
                while ((i = _phrase.IndexOf(_check, i)) != -1)
                {
                    i += _phrase.Length;
                    count++;
                }
                return count;
            }
        }
    }
}
