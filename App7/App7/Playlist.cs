using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace App7
{
    public class Playlist:INotifyPropertyChanged
    {
        private ObservableCollection<Record> allPlaylists;

        public ObservableCollection<Record> AllPlaylists
        {
            get { return allPlaylists; }
            set
            {
                allPlaylists = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AllPlaylists)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Playlist()
        {
            AllPlaylists = GetMockPlayList(10);
        }

        private ObservableCollection<Record> GetMockPlayList(int k)
        {
            var list = new ObservableCollection<Record>();
            for (int i = 0; i<k; i++)
            {
                list.Add(new Record() { fileName = $"{i}", size = 2 * i }); ;
            }
            return list;
        }
    }
}
