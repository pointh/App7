using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App7
{
    public class Playlist
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public static List<Record> AllPlaylists { get; set; } = new List<Record>();

        public Playlist()
        {
            AllPlaylists = GetMockPlayList(10);
        }

        private List<Record> GetMockPlayList(int k)
        {
            var list = new List<Record>();
            for (int i = 0; i<k; i++)
            {
                list.Add(new Record() { fileName = $"{i}", size = 2 * i }); ;
            }
            return list;
        }

    }
}
