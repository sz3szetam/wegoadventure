using CommunityToolkit.Mvvm.ComponentModel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Szalloda
{
    public partial class SzallodaViewModel : BaseViewModel
    {
        private AddNewEmployeeViewModel _addNewEmployeeeViewModel;
        private DeleteEmployeeViewModel _deleteEmployeeViewModel;
        

        public SzallodaViewModel()
        {
            _addNewEmployeeeViewModel = new AddNewEmployeeViewModel();
            _deleteEmployeeViewModel = new DeleteEmployeeViewModel();
        }
        public SzallodaViewModel(AddNewEmployeeViewModel addNewEmployeeeViewModel, DeleteEmployeeViewModel deleteEmployeeViewModel)
        {
            _addNewEmployeeeViewModel = addNewEmployeeeViewModel;
            _deleteEmployeeViewModel = deleteEmployeeViewModel;
            _currentSzallodaChildView = _addNewEmployeeeViewModel;
        }

        [RelayCommand]
        public void AddNewEployeeView()
        {
            CurrentSzallodaChildView = _addNewEmployeeeViewModel;
        }
        [RelayCommand]
        public void DeleteEmployeeView()
        {
            CurrentSzallodaChildView = _deleteEmployeeViewModel;
        }
        [ObservableProperty]
        private BaseViewModel _currentSzallodaChildView;
    }
}
