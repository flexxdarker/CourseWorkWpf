using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWpf.ViewModels
{
    internal class UserClass
    {
        public TimeOnly time;
        public int dificult;
        public List<List<string>> dificults = new List<List<string>>()
        { 
            new List<string>() { "Sphinx of black quartz, judge my vow!", "The quick brown fox jumps over the lazy dog." },
            new List<string>() { "She sells seashells by the seashore.", "How can a clam cram in a clean cream can?" },
            new List<string>() { "Peter Piper picked a peck of pickled peppers.", "Six slippery snails slid slowly seaward." },
            new List<string>() { "Unique New York, you know you need unique New York.", "I scream, you scream, we all scream for ice cream!" },
            new List<string>() { "Fuzzy Wuzzy was a bear, Fuzzy Wuzzy had no hair.", "Red lorry, yellow lorry, red lorry, yellow lorry." }
        };
        public bool isStart = true;
        public bool isStop = false;
        public bool isCaseSensetive = false;
    }
}
