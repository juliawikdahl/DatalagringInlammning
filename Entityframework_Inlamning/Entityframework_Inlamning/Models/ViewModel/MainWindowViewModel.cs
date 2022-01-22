using Entityframework_Inlamning.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityframework_Inlamning.Models.ViewModel
{
    internal class MainWindowViewModel : ObservableObject 
    {


        public RelayCommand GetCustomerViewCommand { get; set; }
        public RelayCommand CreateCustomerViewCommand { get; set; }

        public RelayCommand GetErrandViewCommand { get; set; }
        public RelayCommand CreateErrandViewCommand { get; set; }

        public GetCustomerViewModel GetCustomerViewModel { get; set; }

        public CreateCustomerViewModel CreateCustomerViewModel { get; set; }

        public GetErrandViewModel GetErrandViewModel { get; set; }
        public CreateErrandViewModel CreateErrandViewModel { get; set; }



        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        

        public MainWindowViewModel()
        {
            GetCustomerViewModel = new GetCustomerViewModel();
            CreateCustomerViewModel = new CreateCustomerViewModel();
            GetErrandViewModel = new GetErrandViewModel();
            CreateErrandViewModel = new CreateErrandViewModel();
            CurrentView = GetCustomerViewModel;



            GetCustomerViewCommand = new RelayCommand( x => CurrentView = GetCustomerViewModel);
            CreateCustomerViewCommand = new RelayCommand(x => CurrentView = CreateCustomerViewModel);
            GetErrandViewCommand = new RelayCommand(x => CurrentView = GetErrandViewModel);
            CreateErrandViewCommand = new RelayCommand(x => CurrentView = CreateErrandViewModel);

           
        }
    }
}
