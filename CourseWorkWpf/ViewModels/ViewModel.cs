using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWpf.ViewModels
{
    internal class ViewModel
    {
        private ObservableCollection<UserClass> phrases;
        public IEnumerable<UserClass> Phrases => phrases;
        public string userPhrases { get; set; }
        public ViewModel() 
        {
            phrases = new ObservableCollection<UserClass>();
            
        }
    }
}
