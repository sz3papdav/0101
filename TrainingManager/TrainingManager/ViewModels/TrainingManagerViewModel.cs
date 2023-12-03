using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Linq;
using System.Collections.ObjectModel;
using TrainingManager.Models;

namespace TrainingManager.ViewModels
{
    internal partial class TrainingManagerViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<AlapAdatok> _alapadatokk = new ObservableCollection<AlapAdatok>();

        [ObservableProperty]
        private ObservableCollection<string> _korosztaly = new ObservableCollection<string>(new Korosztaly().OsszesKorosztaly);


        [ObservableProperty]
        private AlapAdatok _selecteduser;
        public string _selectedKorosztaly = string.Empty;

        public string SelectedKorosztaly
        {
            get => _selectedKorosztaly;
            set
            {
                SetProperty(ref _selectedKorosztaly, value);
                Selecteduser.Korosztaly = _selectedKorosztaly;
            }
        }


        public TrainingManagerViewModel()
        {
            Selecteduser = new AlapAdatok();
        }
        [RelayCommand]
        public void DoSave(AlapAdatok newpeople)
        {
            Alapadatokk.Add(newpeople);
            OnPropertyChanged(nameof(AlapAdatok));
        }
        [RelayCommand]
        void DoNewPeople()
        {
            Selecteduser = new AlapAdatok();
        }
        [RelayCommand]
        public void DoRemove(AlapAdatok trainingmanagerToDelete)
        {
            Alapadatokk.Remove(trainingmanagerToDelete);
            OnPropertyChanged(nameof(AlapAdatok));
        }
    }
}
