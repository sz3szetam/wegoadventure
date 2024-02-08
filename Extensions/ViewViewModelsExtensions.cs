using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Grades;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Grades;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.Felhasznalo;
using KretaBasicSchoolSystem.Desktop.ViewModels.Felhasznalo;
using KretaBasicSchoolSystem.Desktop.Views.Szalloda;
using KretaBasicSchoolSystem.Desktop.ViewModels.Szalloda;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // School Citizens
            // Students
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentViewModel>()
            });
            // Teacher
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>()
            });
            // Parent
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentViewModel>() 
            });

            //Grade
            services.AddSingleton<GradesViewModel>();
            services.AddSingleton<GradesView>(s => new GradesView()
            {
                DataContext = s.GetRequiredService<GradesViewModel>()
            });

            //ActualClass
            services.AddSingleton<ActualClassViewModel>();
            services.AddSingleton<ActualClassView>(s => new ActualClassView()
            {
                DataContext = s.GetRequiredService<ActualClassViewModel>()
            });
            //Classes
            services.AddSingleton<ClassesSchoolViewModel>();
            services.AddSingleton<ClassesSchoolView>(s => new ClassesSchoolView()
            {
                DataContext = s.GetRequiredService<ClassesSchoolViewModel>()
            });
            //EndOfSemester
            services.AddSingleton<EndOfSemesterViewModel>();
            services.AddSingleton<EndOfSemesterView>(s => new EndOfSemesterView()
            {
                DataContext = s.GetRequiredService<EndOfSemesterViewModel>()
            });
            //EndOfYear
            services.AddSingleton<EndOfYearViewModel>();
            services.AddSingleton<EndOfYearView>(s => new EndOfYearView()
            {
                DataContext = s.GetRequiredService<EndOfYearViewModel>()
            });
            //Felhasznalo
            services.AddSingleton<FelhasznaloViewModel>();
            services.AddSingleton<FelhasznaloView>(s => new FelhasznaloView()
            {
                DataContext = s.GetRequiredService<FelhasznaloViewModel>()
            });
            //Szalloda
            services.AddSingleton<SzallodaViewModel>();
            services.AddSingleton<SzallodaView>(s => new SzallodaView()
            {
                DataContext = s.GetRequiredService<SzallodaViewModel>()
            });
        }
    }
}
