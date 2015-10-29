using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.IsolatedStorage;

namespace Therondels.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            this.Settings = IsolatedStorageSettings.ApplicationSettings;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ItemViewModel> Items { get; private set; }

        public IsolatedStorageSettings Settings { get; private set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            this.Items.Clear();
            if (this.Settings.Contains("actus"))
            {
                foreach (var entry in (List<Champs>)this.Settings["actus"])
                {
                    this.Items.Add(new ItemViewModel() { Title = entry.Title, Description = DateTime.Parse(entry.PubDate).ToString("d")  + " - " + entry.Description, Link = entry.Link });
                }
            }
            
            this.IsDataLoaded = true;
        }
    }
}