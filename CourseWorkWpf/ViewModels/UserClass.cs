using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWpf.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    internal class UserClass
    {
        public List<string> firstDificult = new List<string>();
        public List<string> secondDificult = new List<string>();
        public List<string> thirdDificult = new List<string>();
        public List<string> fourthDificult = new List<string>();
        public List<string> fifthDificult = new List<string>();
        public int countOfChars;
        public double chars;
        public int dificult { get; set; }
        public int fails { get; set; }
        public bool isStart { get; set; }
        public bool isStop { get; set; }
        public bool isCaseSensetive
        {
            get; set;
        }
    }
}
