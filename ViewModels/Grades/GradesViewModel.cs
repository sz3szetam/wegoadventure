using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.Grades
{
    public partial class GradesViewModel : BaseViewModel
    {
        private EndOfYearViewModel _endOfYearViewModel;
        private EndOfSemesterViewModel _endOfSemesterViewModel;
        private ClassesSchoolViewModel _classesSchoolViewModel;
        public ActualClassViewModel _actualClassViewModel;
        public GradesViewModel()
        {
            _currentGradesChildView = new ActualClassViewModel();
            _endOfSemesterViewModel = new EndOfSemesterViewModel();
            _classesSchoolViewModel = new ClassesSchoolViewModel();
            _endOfYearViewModel = new EndOfYearViewModel();
            _actualClassViewModel = new ActualClassViewModel();

        }

        public GradesViewModel(ActualClassViewModel actualClassViewModel, EndOfSemesterViewModel endOfSemesterViewModel, ClassesSchoolViewModel classesSchoolViewModel, EndOfYearViewModel endOfYearViewModel)
        {
            _actualClassViewModel = actualClassViewModel;
            _classesSchoolViewModel = classesSchoolViewModel;
            _endOfYearViewModel = endOfYearViewModel;
            _endOfSemesterViewModel = endOfSemesterViewModel;

            _currentGradesChildView = new ActualClassViewModel();
        }


        [ObservableProperty]
        private BaseViewModel _currentGradesChildView;

        [RelayCommand]
        public void ActualClassView()
        {
            CurrentGradesChildView = _actualClassViewModel;
        }
        [RelayCommand]
        public void ClassesSchoolView()
        {
            CurrentGradesChildView = _classesSchoolViewModel;
        }
        [RelayCommand]
        public void EndOfSemesterView()
        {
            CurrentGradesChildView = _endOfSemesterViewModel;
        }
        [RelayCommand]
        public void EndOfYearView()
        {
            CurrentGradesChildView = _endOfYearViewModel;
        }
    }

}
