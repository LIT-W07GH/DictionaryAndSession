using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryAndSession.Models
{
    public class CountsViewModel
    {
        public string Text { get; set; }
        public Dictionary<char, int> Counts { get; set; }
    }
}
