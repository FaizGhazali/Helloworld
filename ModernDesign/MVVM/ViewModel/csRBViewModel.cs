using System;
using ModernDesign.MVVM.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel
{
    public class csRBViewModel
    {
        public RelayCommand ChangeViewCommand { get; set; }
        public RelayCommand ChangeThreadingViewCommand { get; set; }
        public RelayCommand ChangeHomeRadioCommand { get; set; }

        public csRBViewModel()
        {
            ChangeViewCommand = new RelayCommand(o => RequestViewChange());
            ChangeThreadingViewCommand = new RelayCommand(o => ReqThreadingViewChange());
            ChangeHomeRadioCommand = new RelayCommand(o => ReqHomeRadioViewChange());
        }

        public void RequestViewChange()
        {
            Messenger.Instance.Send(new ChangeViewMessage { ViewModel = new DiscoveryViewModel() });

        }
        public void ReqThreadingViewChange()
        {
            Messenger.Instance.Send(new ChangeViewMessage { ViewModel = new ThreadingViewModel() });
        }

        public void ReqHomeRadioViewChange()
        {
            Messenger.Instance.Send(new ChangeRadioMessage { RadioModel = new RadioButtonView() });
        }

    }   
     
}
