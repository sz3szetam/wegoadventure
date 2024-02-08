using CommunityToolkit.Mvvm.ComponentModel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Felhasznalo
{
    public partial class FelhasznaloViewModel : BaseViewModel
    {
        private AddUserViewModel _addUserViewModel;
        private CalendarViewModel _calendarViewModel;
        private ModifyUserViewModel _modifyUserViewModel;


        public FelhasznaloViewModel()
        {
            _addUserViewModel = new AddUserViewModel();
            _calendarViewModel = new CalendarViewModel();
            _modifyUserViewModel = new ModifyUserViewModel();
            
        }
        public FelhasznaloViewModel(AddUserViewModel addUserViewModel, CalendarViewModel calendarViewModel, ModifyUserViewModel modifyUserViewModel)
        {
            _addUserViewModel = addUserViewModel;
            _calendarViewModel = calendarViewModel;
            _modifyUserViewModel = modifyUserViewModel;
            _currentFelhasznaloChildView = new AddUserViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentFelhasznaloChildView;

        [RelayCommand]
        public void AddUserView()
        {
            CurrentFelhasznaloChildView = _addUserViewModel;
        }
        [RelayCommand]
        public void CalendarView()
        {
            CurrentFelhasznaloChildView = _calendarViewModel;
        }
        [RelayCommand]
        public void ModifyUserView() 
        {
            CurrentFelhasznaloChildView = _modifyUserViewModel;
        }
    }
    
}
