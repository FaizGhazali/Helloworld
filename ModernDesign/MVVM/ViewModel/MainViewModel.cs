using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }
        public PracticeRadioViewModel PracticeRVM { get; set; }

        private object _currentView;
        private object _currentRadioView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public object CurrentRadioView 
        {
            get { return _currentRadioView; }
            set { _currentRadioView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            PracticeRVM = new PracticeRadioViewModel();


            CurrentView = HomeVm;
            CurrentRadioView = PracticeRVM;
            
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
            
        }
    }
}
