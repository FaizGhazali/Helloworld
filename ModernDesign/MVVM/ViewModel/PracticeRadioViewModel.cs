using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    public class PracticeRadioViewModel
    {
        public RelayCommand ChangeViewCommand { get; set; }
        public RelayCommand ChangeHomeViewCommand { get; set; }

        public PracticeRadioViewModel()
        {
            ChangeViewCommand = new RelayCommand(o => RequestViewChange());
            ChangeHomeViewCommand = new RelayCommand(o => ReqHomeViewChange());
        }

        public void RequestViewChange()
        {
            Messenger.Instance.Send(new ChangeViewMessage { ViewModel = new DiscoveryViewModel() });
            
        }
        public void ReqHomeViewChange()
        {
            Messenger.Instance.Send(new ChangeViewMessage { ViewModel = new HomeViewModel() });
        }

        
    }
}
