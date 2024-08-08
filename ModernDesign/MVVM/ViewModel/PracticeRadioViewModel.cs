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
        public RelayCommand HMViewCommand { get; set; }
        

        public PracticeRadioViewModel()
        {
            HMViewCommand = new RelayCommand(o => RequestViewChange());
        }

        public void RequestViewChange()
        {
            DiscoveryViewModel DVM = GetExistingViewModel();
            Messenger.Instance.Send(new ChangeViewMessage { ViewModel = new DiscoveryViewModel() });
        }
        private DiscoveryViewModel GetExistingViewModel()
        {
            // Logic to get the existing view model instance
            // This can be a field, property, or a method that returns the instance
            return someExistingViewModelInstance;
        }

    }
}
