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

        public string Getcheck()
        {
            return _check;
        }
    }
}
