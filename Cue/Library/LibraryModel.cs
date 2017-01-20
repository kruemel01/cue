using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cue.Library
{
    class LibraryModel : ObservableObject
    {
        public readonly ObservableCollection<AudioFile> Files;

        public LibraryModel()
        {
            Files = new ObservableCollection<AudioFile>();
            Files.Add(new AudioFile("Test", "asdf", false, new WaveOut()));
        }
    }
}
