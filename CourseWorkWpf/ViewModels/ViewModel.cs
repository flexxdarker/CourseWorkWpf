using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CourseWorkWpf.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        public UserClass userClass { get; set; }
        public string userPhrases { get; set; }
        public string PhrasesToWrite { get; set; }
        public double Chars { get; set; }
        List<List<string>> difs = new List<List<string>>()
        {
            new List<string>() { "Sphinx of black quartz, judge my vow!", "The quick brown fox jumps over the lazy dog.", "The seething sea ceaseth and thus the seething sea sufficeth us." },
            new List<string>() { "She sells seashells by the seashore.", "How can a clam cram in a clean cream can?", "How can you can a can as a canner can can a can?" },
            new List<string>() { "Peter Piper picked a peck of pickled peppers.", "Six slippery snails slid slowly seaward.", "The sixth sick sheikh's sixth sheep's sick."},
            new List<string>() { "Unique New York, you know you need unique New York.", "I scream, you scream, we all scream for ice cream!", "I wish to wash my Irish wristwatch."},
            new List<string>() { "Fuzzy Wuzzy was a bear, Fuzzy Wuzzy had no hair.", "Red lorry, yellow lorry, red lorry, yellow lorry.", "Irish wristwatch, Swiss wristwatch."}
        };
        DispatcherTimer dispatcherTimer = new DispatcherTimer()
        { Interval = TimeSpan.FromSeconds(10), };
        public ViewModel()
        {
            UserClass uc = new UserClass()
            {
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
            dispatcherTimer.Start();
            PhrasesToWrite = string.Empty;
            userPhrases = string.Empty;
            Random rnd = new Random();
            int rand;
            rand = rnd.Next(3);
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
            dispatcherTimer.Stop();
            if (userClass.isStop)
            {
                for (int i = 0; i < userPhrases.Length; i++)
                {
                    if (PhrasesToWrite.ToLower()[i] != userPhrases.ToLower()[i])
                    {
                        userClass.fails++;
                    }
                }
                Chars = userPhrases.Length / dispatcherTimer.Interval.TotalSeconds;
            }
            userClass.isStop = false;
            userClass.isStart = true;
        }
    }
}
