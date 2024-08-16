using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernDesign.Core;
using ModernDesign.MVVM.View;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        //Radio
        public PracticeRadioViewModel PracticeRVM { get; set; }
        public csRBViewModel csRBVM { get; set; }



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
            csRBVM = new csRBViewModel();


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
            Messenger.Instance.Register<ChangeViewMessage>(OnChangeViewMessage);
            Messenger.Instance.Register<ChangeRadioMessage>(OnChangeRadioMessage);

        }
        private void OnChangeViewMessage(ChangeViewMessage message)
        {
            CurrentView = message.ViewModel;
        }
        private void OnChangeRadioMessage(ChangeRadioMessage message)
        {
            CurrentRadioView = message.RadioModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
