using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Felhasznalo;
using KretaBasicSchoolSystem.Desktop.ViewModels.Grades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Szalloda;
using System.Printing;

namespace KretaBasicSchoolSystem.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private GradesViewModel _gradesViewModel;
        private SzallodaViewModel _szallodaViewModel;
        private FelhasznaloViewModel _felhasznaloViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _gradesViewModel = new GradesViewModel();
            _szallodaViewModel = new SzallodaViewModel();
            _felhasznaloViewModel = new FelhasznaloViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel, 
            GradesViewModel gradesViewModel,
            SzallodaViewModel szallodaViewModel,
            FelhasznaloViewModel felhasznaloViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _gradesViewModel = gradesViewModel;
            _szallodaViewModel = szallodaViewModel;
            _felhasznaloViewModel = felhasznaloViewModel;


            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }
        [RelayCommand]
        public void ShowGrades()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _gradesViewModel;
        }
        [RelayCommand]
        public void ShowSzallodas()
        {
            Caption = "Szállodások";
            Icon = IconChar.UserGroup;
            CurrentChildView = _szallodaViewModel;
        }
        [RelayCommand]
        public void ShowFelhasznalok()
        {
            Caption = "Felhasználók";
            Icon = IconChar.UserGroup;
            CurrentChildView = _felhasznaloViewModel;
        }
    }
}
