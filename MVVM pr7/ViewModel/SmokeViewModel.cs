using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using MVVM_pr7.Model;
using MVVM_pr7.View;

namespace MVVM_pr7.ViewModel
{

    public class SmokeViewModel : INotifyPropertyChanged
    {
        private SmokeModel selectedSmoke;

        OpenSave fileService;
        AppInt ApInterface;

        public ObservableCollection<SmokeModel> Smokes { get; set; }

        private RelayCommand saveFile;
        public RelayCommand SaveFileCommand
        {
            get
            {
                return saveFile ??
                  (saveFile = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (ApInterface.SaveFileDialog() == true)
                          {
                              fileService.Save(ApInterface.FilePath, Smokes.ToList());
                              ApInterface.ShowMessage("Файл сохранен");
                          }
                      }
                      catch (Exception ex)
                      {
                          ApInterface.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand openFile;
        public RelayCommand OpenFileCommand
        {
            get
            {
                return openFile ??
                  (openFile = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (ApInterface.OpenFileDialog() == true)
                          {
                              var smokes = fileService.Open(ApInterface.FilePath);
                              Smokes.Clear();
                              foreach (var product in smokes)
                                  Smokes.Add(product);
                              ApInterface.ShowMessage("Файл открыт");
                          }
                      }
                      catch (Exception ex)
                      {
                          ApInterface.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        private RelayCommand addSmoke;
        public RelayCommand AddSmokeCommand
        {
            get
            {
                return addSmoke ??
                  (addSmoke = new RelayCommand(obj =>
                  {
                      SmokeModel smoke = new SmokeModel("", "", 0);
                      Smokes.Insert(0, smoke);
                      selectedSmoke = smoke;
                  }));
            }
        }

        private RelayCommand removeSmoke;
        public RelayCommand RemoveSmokeCommand
        {
            get
            {
                return removeSmoke ??
                  (removeSmoke = new RelayCommand(obj =>
                  {
                      SmokeModel smoke = obj as SmokeModel;
                      if (smoke != null)
                      {
                          Smokes.Remove(smoke);
                      }
                  },
                 (obj) => Smokes.Count > 0));
            }
        }
        public SmokeModel SelectedSmoke
        {
            get { return selectedSmoke; }
            set
            {
                selectedSmoke = value;
                OnPropertyChanged("SelectedSmoke");
            }
        }

        public SmokeViewModel(AppInt dialogService, OpenSave fileService)
        {
            ApInterface = dialogService;
            this.fileService = fileService;

            Smokes = new ObservableCollection<SmokeModel>
                {
                    new SmokeModel ("Novo2","Smok", 1950)
                };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }

}
