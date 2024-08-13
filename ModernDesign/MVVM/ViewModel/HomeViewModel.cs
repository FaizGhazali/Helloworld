using ModernDesign.Core;
using ModernDesign.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    class HomeViewModel
    {
        public RelayCommand BorderClickCommand {get; private set; }

        public HomeViewModel()
        {
            BorderClickCommand = new RelayCommand(o => RequestViewChange());
        }
        private void RequestViewChange()
        {
            //Handle Click Event
            Messenger.Instance.Send(new ChangeRadioMessage { RadioModel = new csRadioButton() });
        }
    }
}
