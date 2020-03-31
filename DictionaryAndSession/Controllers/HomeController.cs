using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DictionaryAndSession.Models;
using DictionaryAndSession.Data;

namespace DictionaryAndSession.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string text)
        {
            Person p = new Person();

            CountsViewModel vm = new CountsViewModel();
            if (!String.IsNullOrEmpty(text))
            {
                vm.Counts = GetCounts(text);
                vm.Text = text;
            }
            return View(vm);
        }

        private Dictionary<char, int> GetCounts(string text)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
            {
                counts.Add(letter, 0);
            }

            foreach (char letter in text.ToUpper())
            {
                if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
            }

            return counts;
        }
    }
}
