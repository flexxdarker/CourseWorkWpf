using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CourseWorkWpf.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        public UserClass userClass { get; set; }
        public string userPhrases { get; set; }
        public string PhrasesToWrite { get; set; }
        List<List<string>> difs = new List<List<string>>()
        {
            new List<string>() { "Sphinx of black quartz, judge my vow!", "The quick brown fox jumps over the lazy dog." },
            new List<string>() { "She sells seashells by the seashore.", "How can a clam cram in a clean cream can?" },
            new List<string>() { "Peter Piper picked a peck of pickled peppers.", "Six slippery snails slid slowly seaward." },
            new List<string>() { "Unique New York, you know you need unique New York.", "I scream, you scream, we all scream for ice cream!" },
            new List<string>() { "Fuzzy Wuzzy was a bear, Fuzzy Wuzzy had no hair.", "Red lorry, yellow lorry, red lorry, yellow lorry." }
        };

        public ViewModel()
        {
            UserClass uc = new UserClass()
            {
                time = new TimeOnly(),
                firstDificult = difs[0],
                secondDificult = difs[1],
                thirdDificult = difs[2],
                fourthDificult = difs[3],
                fifthDificult = difs[4],
                countOfChars = 0,
                chars = 0,
                dificult = 1,
                fails = 0,
                isStart = true,
                isStop = false,
                isCaseSensetive = false,
            };
            userClass = uc;
        }
        public void Start()
        {
            PhrasesToWrite = string.Empty;
            userPhrases = string.Empty;
            Random rnd = new Random();
            int rand;
            rand = rnd.Next(2);
            userClass.time = new TimeOnly(ticks: 1);
            switch (userClass.dificult)
            {
                case 1:
                    PhrasesToWrite = userClass.firstDificult[rand]; break;
                case 2:
                    PhrasesToWrite = userClass.secondDificult[rand]; break;
                case 3:
                    PhrasesToWrite = userClass.thirdDificult[rand]; break;
                case 4:
                    PhrasesToWrite = userClass.fourthDificult[rand]; break;
                case 5:
                    PhrasesToWrite = userClass.fifthDificult[rand]; break;
            }
            userClass.isStart = false;
            userClass.isStop = true;
        }
        public void Stop() 
        {
            if (userClass.isStop)
            {
                for (int i = 0; i < userPhrases.Length; i++)
                {
                    if (PhrasesToWrite[i] != userPhrases[i])
                    {
                        userClass.fails++;
                    }
                }
                int tmpTime = ((int)userClass.time.Ticks);
                userClass.chars = userPhrases.Length / tmpTime;
            }
            userClass.isStop = false;
            userClass.isStart = true;
        }
    }
}
